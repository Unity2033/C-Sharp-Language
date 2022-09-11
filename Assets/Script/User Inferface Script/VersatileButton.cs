using UnityEngine;


public class VersatileButton : MonoBehaviour
{
    public void GameStart()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        Time.timeScale = 1;
        transform.root.gameObject.SetActive(false);

        Instantiate(Resources.Load<GameObject>("Character"));
    }

    public void GameExit()
    {
#if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false;      
#elif UNITY_WEBGL
         Application.OpenURL("http://google.com");
#else
        Application.Quit();
#endif

    }
}
