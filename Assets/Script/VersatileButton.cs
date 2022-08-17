using UnityEngine;


public class VersatileButton : MonoBehaviour
{
    public void Scene(string name)
    {
        Loading.LoadScene(name);
    }

    public void Exit()
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
