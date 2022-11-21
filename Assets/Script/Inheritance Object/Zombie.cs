using UnityEngine;
using UnityEngine.AI;

public class Zombie : Biology
{
    protected NavMeshAgent agent;
    private GameObject character;
    [SerializeField] float maxHealth;

    void Start()
    {
        maxHealth = health;
        agent = GetComponent<NavMeshAgent>();
        character = GameObject.Find("Character");
    }

    void Update()
    {
        direction = character.transform.position;

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
            agent.SetDestination(direction);
        }
    }

    public void DistanceSensor()
    {
        direction.y = 0;

        // 캐릭터의 위치와 자기 자신의 거리가 2.5보다 작다면 
        if (Vector3.Distance(character.transform.position, transform.position) <= 2.5f)
        {
            agent.isStopped = true;

            transform.LookAt(direction);

            animator.SetBool("Attack", true);

            if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f)
                {
                    character.GetComponent<Character>().health -= 10;
                    StartCoroutine(character.GetComponentInChildren<CameraShake>().Shake(0.5f, 0.25f));
                }

                if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {           
                    animator.Play("Attack", -1, 0f);
                }
            }
        }
        else // 캐릭터의 위치와 자기 자신의 거리가 2.5보다 멀어졌다면
        {
            agent.isStopped = false;
            animator.SetBool("Attack", false);
        }
    }
}
