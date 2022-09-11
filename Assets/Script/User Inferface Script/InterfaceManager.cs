using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Text timer;

    private void OnEnable()
    {
        title.text = "Game Running Time :" + Time.time.ToString("N2");
        timer.text = "Zombie Kills : " + GameManager.instance.count.ToString();
    }
}
