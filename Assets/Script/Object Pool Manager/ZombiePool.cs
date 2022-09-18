using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePool : ObjectPool
{   
    // ObjectPool에 담을 수 있는 게임 오브젝트를 설정합니다.
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
