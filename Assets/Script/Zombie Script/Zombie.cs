using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    [SerializeField] float maxHealth;
    public float health;
    private Animator animator;
    private NavMeshAgent agent;
    private GameObject character;

   void Start()
    {
        maxHealth = health;

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        character = GameObject.Find("Character");          
    }

    // 메모리 풀에서 다시 활성화시킬 때 체력과 속도를 초기화시켜 줍니다.
    private void OnEnable()
    {
        health = 100;      
    }

    void Update()
    {                          
        float tempHealth = 1 - (health / maxHealth);
                                                                    
        animator.SetLayerWeight(animator.GetLayerIndex("Other Layer"), tempHealth);

        if (health <= 0)
        {
            agent.speed = 0;
            animator.Play("Death");

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
            DistanceSensor();
            agent.SetDestination(character.transform.position);
        }
    }

    public void DistanceSensor()
    {
        // 캐릭터의 위치와 자기 자신의 거리가 2.5보다 작다면 
        if (Vector3.Distance(character.transform.position, transform.position) <= 2.5f)
        {
            agent.speed = 0;
            transform.LookAt(character.transform);
            animator.SetBool("Attack", true);

            if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {
                    character.GetComponent<Control>().health -= 10;
                    animator.Rebind();
                }
            }
        }
        else // 캐릭터의 위치와 자기 자신의 거리가 2.5보다 멀어졌다면
        {
            agent.speed = 5f;
            animator.SetBool("Attack", false);
        }
    }
}
