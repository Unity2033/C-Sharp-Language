using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public RandomSpawn spawn;

    public static ObjectPool instance;

    private List<GameObject> zombieContainer= new List<GameObject>();

    [SerializeField] GameObject zombie;

    private void Awake()
    {
        // static ��ü�� ����ϱ� ���� ObjectPool�� instance ������ �־��ݴϴ�.
        instance = this;
    }

    void Start()
    {  
        CreateObject(zombie, ActivePostion());
    }

    public void CreateObject(GameObject parameterObject, Vector3 tVector)
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject tempObject = Instantiate(parameterObject, tVector, Quaternion.identity);
            tempObject.SetActive(false);
            zombieContainer.Add(tempObject);
        }
    }
    
    public Vector3 ActivePostion()
    {
        return spawn.RandomPosition();
    }

    public GameObject GetPooled()
    {
        for(int i = 0; i < zombieContainer.Count; i++)
        {
            if(zombieContainer[i].activeInHierarchy == false)
            {
                return zombieContainer[i];
            }
        }

        return null;
    }
}
