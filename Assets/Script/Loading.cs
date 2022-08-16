using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    static string sceneName;

    [SerializeField] Slider progress;

    public static void LoadScene(string name)
    {
        sceneName = name;
        // SceneManager.LoadScene : 동기 방식의 씬을 불러오는 함수입니다.
        // 씬을 다 불러오기 전까지 아무 작업도 진행할 수 없는 상태입니다. 
        SceneManager.LoadScene("Loading");
    }

    void Start()
    {
        StartCoroutine(nameof(LoadProcess));
    }
    
    IEnumerator LoadProcess()
    {
        // SceneManager.LoadSceneAsync : 비동기 방식의 씬을 불러오는 함수입니다.
        // 씬을 불러오는 작업하는 도중에 다른 작업을 수행할 수 있는 상태입니다.
        AsyncOperation scene = SceneManager.LoadSceneAsync(sceneName);

        // allowSceneActivation 씬의 로딩이 끝나면 자동으로 불러온 씬으로 이동할 것인지 설정하는 기능입니다.
        // allowSceneActivation의 값이 false이면 씬을 90%까지만 불러오고 다음 씬으로 넘어가지 않고 기다립니다.
        scene.allowSceneActivation = false;

        float timer = 0f;

        // 씬의 로딩이 끝나지 않았다면 반복하도록 설정합니다.
        while (!scene.isDone)
        {
            // 반복문이 한번 반복할 때마다 유니티에게 제어권을 넘겨줍니다.
            // 반복문이 돌아갈 때 제어권을 넘겨주지 않으면 반복문이 끝나기 전에는 화면이 갱신되지 않아 Progress bar가 업데이트되지 않는 문제 발생할 수 있습니다.
            yield return null;

            if (scene.progress < 0.9f)
            {
                progress.value = scene.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                // progress의 value를 0.9에서 1로 1초에 걸쳐서 채우도록 설정합니다.
                progress.value = Mathf.Lerp(0.9f, 1f, timer);

                // 끝점의 값이 주어졌을 때 그 사이에 위치한 값을 추정하기 위하여 직선에 따라 선형적으로 계산하는 방법입니다.

                if(progress.value >= 1f)
                {
                    scene.allowSceneActivation = true;
                    yield break;
                }
            }

        }
        
    }

   
}
