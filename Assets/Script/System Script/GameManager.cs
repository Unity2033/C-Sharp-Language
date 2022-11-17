using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public int count;
 
    private void Awake()
    {
        if (instance == null)
        {
           instance = this;
        }
    }
}
