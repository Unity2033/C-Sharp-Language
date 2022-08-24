using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public int health;
    private Animator animator;
    private NavMeshAgent agent;
    private GameObject character;

   void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        character = GameObject.Find("Character");          
    }

    // �޸� Ǯ���� �ٽ� Ȱ��ȭ��ų �� ü�°� �ӵ��� �ʱ�ȭ���� �ݴϴ�.
    private void OnEnable()
    {
        health = 100;
        // agent.speed = 10;
    }

    void Update()
    {
        if (health <= 0)
        {
            // �ִϸ����� ��Ʈ�ѷ����� ���� �ִϸ������� ������ �̸��� ��Death���� �� 
            if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Death"))
            {
                // ���� �ִϸ��̼��� ���൵�� 1���� ũ�ų� ���ٸ� �޸� Ǯ�� �ݳ��մϴ�.
                if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {
                    ObjectPool.instance.InsertQueue(gameObject);
                    transform.position = ObjectPool.instance.ActivePostion();
                }
            }
        }
        else
        {
            agent.SetDestination(character.transform.position);
        }
    }

    public void Death()
    {
        if (health <= 0)
        {
            agent.speed = 0;
            animator.Play("Death");      
        }
    }

    // ���� ������Ʈ�� �浹 �� �϶� ȣ��Ǵ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Character"))
        {
            agent.speed = 0;
            transform.LookAt(character.transform);
            animator.SetBool("Attack", true);

            if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {
                    other.GetComponent<Control>().health -= 10;
                    animator.Rebind(); 
                }
            }
        }
    }

    // ���� ������Ʈ�� �浹�� ����� �� ȣ��Ǵ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            agent.speed = 3.5f;
            animator.SetBool("Attack", false);
        }
    }
}
