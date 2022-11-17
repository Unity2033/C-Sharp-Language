using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{
    public void NextScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
