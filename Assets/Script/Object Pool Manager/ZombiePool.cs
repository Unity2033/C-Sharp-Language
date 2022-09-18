using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePool : ObjectPool
{   
    // ObjectPool�� ���� �� �ִ� ���� ������Ʈ�� �����մϴ�.
    public GameObject zombie;

    public override void CreateObject(GameObject tObject, Vector3 tVector)
    {
        base.CreateObject(tObject, tVector);
    }

    public override GameObject GetQueue()
    {
        return base.GetQueue();
    }

    public IEnumerator CreateZombie()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);

            GetQueue();
        }
    }
}
