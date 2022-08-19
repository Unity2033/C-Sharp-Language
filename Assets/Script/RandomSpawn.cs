using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(nameof(CreateZombie));
    }

    public IEnumerator CreateZombie()
    {
        while(true)
        {
            ObjectPool.instance.GetQueue();
            yield return new WaitForSeconds(10f);
        }
    }

    public Vector3 RandomPosition()
    {
        // ���� ������
        /*
           x^2 + z^2 <= r^2
           ���� �����Ŀ��� ������ x�� z�� �ش��ϴ� ���� ������ r�� �� �ȿ� �����ϴ� �����Դϴ�.

           �������� ���� 

           �������� ������ ���� ������ -���������� +�������� ���̱��� �Դϴ�.
           0.3^2 + z^2 = 1
           z = ��Ʈ 1^2 - 0.3^2
           z = ��Ʈ 1 - 0.09
           z = ��Ʈ 0.91
           z = 0.95 (�ٻ簪)

           ������ 1�� ���� ������ (0.3, 0.95)
        */

        // ���� ������Ʈ�� �߽����� ���� ������ 100�� ���� �����մϴ�.
        float radius = 100f;

        // ù ��°�� x���� ����մϴ�.
        // ������ �������� -50, 50 ������ ���� ���� �����մϴ�.
        float x = Random.Range(-radius, radius);

        // ������
        float z = Mathf.Sqrt(Mathf.Pow(radius, 2) - Mathf.Pow(x, 2));

        // �������� 0�� 1������ �������� �����ϰ� 0�� ������ ���� ������ z�� z ������ �־��ָ� �˴ϴ�.
        if(Random.Range(0,2) == 0)
        {
            z = -z;
        }

        return new Vector3(x,0,z);
    }
}
