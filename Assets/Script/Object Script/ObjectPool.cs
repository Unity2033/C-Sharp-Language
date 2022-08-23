using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public RandomSpawn spawn;
    public static ObjectPool instance;

    // ObjectPool에 담을 수 있는 게임 오브젝트를 설정합니다.
    [SerializeField] GameObject zombie;

    // 게임 오브젝트를 담을 수 있는 자료구조 Queue를 선언합니다.
    public Queue<GameObject> queue = new Queue<GameObject>();

    void Start()
    {
        // static 객체를 사용하기 위해 ObjectPool를 instance 변수에 넣어줍니다.
        instance = this;

        for(int i = 0; i < 20; i++)
        {
            GameObject tempPrefab = Instantiate(zombie, spawn.RandomPosition(), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false);
        }
    }

    public Vector3 ActivePostion()
    {
        return spawn.RandomPosition();
    }

    public void InsertQueue(GameObject tobj)
    { 
         queue.Enqueue(tobj);
         tobj.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject tempZombie = queue.Dequeue();
        tempZombie.SetActive(true);

        return tempZombie;
    }
}
