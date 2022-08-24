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

    // 메모리 풀에서 다시 활성화시킬 때 체력과 속도를 초기화시켜 줍니다.
    private void OnEnable()
    {
        health = 100;
        // agent.speed = 10;
    }

    void Update()
    {
        if (health <= 0)
        {
            // 애니메이터 컨트롤러에서 현재 애니메이터의 상태의 이름이 “Death”일 때 
            if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Death"))
            {
                // 현재 애니메이션의 진행도가 1보다 크거나 같다면 메모리 풀에 반납합니다.
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

    // 게임 오브젝트와 충돌 중 일때 호출되는 함수
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

    // 게임 오브젝트와 충돌이 벗어났을 때 호출되는 함수
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            agent.speed = 3.5f;
            animator.SetBool("Attack", false);
        }
    }
}
