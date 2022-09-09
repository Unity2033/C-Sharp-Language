using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    [SerializeField] Text kill;
    [SerializeField] Text playTime;

    public int count;
    public GameObject resultScreen;

    private void Awake()
    {
       if(instance == null)
       {
           instance = this;
       }
    }

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        // Time.time : ������ ����ǰ� ���� ���� �ɸ� �ð�
        playTime.text = "Game Running Time :" + Time.time.ToString("N2");
        kill.text = "Zombie Kills : " + count.ToString();
    }
}
