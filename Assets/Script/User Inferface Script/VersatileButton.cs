using UnityEngine;


public class VersatileButton : MonoBehaviour
{
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
