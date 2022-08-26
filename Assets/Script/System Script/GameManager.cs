using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    [SerializeField] Text kill;
    [SerializeField] Text playTime;

    public int count;
    public GameObject resultScreen;
   
    void Start()
    {
        Time.timeScale = 1;
        instance = this;
    }

    void Update()
    {
        // Time.time : ������ ����ǰ� ���� ���� �ɸ� �ð�
        playTime.text = "Game Running Time :" + Time.time.ToString("N2");
        kill.text = "Zombie Kills : " + count.ToString();
    }
}
