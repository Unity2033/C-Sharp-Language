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

    void Update()
    {
        agent.SetDestination(character.transform.position);

        // 애니메이터 컨트롤러에서 현재 애니메이터의 상태의 이름이 “Death”일 때 
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Death"))
        {
            // 현재 애니메이션의 진행도가 1보다 크거나 같다면 메모리 풀에 반납합니다.
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                ObjectPool.instance.InsertQueue(gameObject);
            }
        }
    }

    public void Death()
    {
        if (health <= 0)
        {
            agent.speed = 0;

            animator.Play("Death");

            transform.position = ObjectPool.instance.ActivePostion();
        }
    }
}
