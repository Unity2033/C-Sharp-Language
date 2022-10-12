using UnityEngine;
using UnityEngine.AI;



public class Zombie : MonoBehaviour
{
    [SerializeField] float maxHealth;
    public float health;
    private Animator animator;
    private NavMeshAgent agent;
    private GameObject character;
    private Vector3 direction;

   void Start()
    {
        maxHealth = health;

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        character = GameObject.Find("Character(Clone)");          
    }

    // �޸� Ǯ���� �ٽ� Ȱ��ȭ��ų �� ü�°� �ӵ��� �ʱ�ȭ���� �ݴϴ�.
    private void OnEnable()
    {
        health = 100;      
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

            // �ִϸ����� ��Ʈ�ѷ����� ���� �ִϸ������� ������ �̸��� ��Death���� �� 
            if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Death"))
            {
                // ���� �ִϸ��̼��� ���൵�� 1���� ũ�ų� ���ٸ� �޸� Ǯ�� �ݳ��մϴ�.
                if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {
                    GameManager.instance.count++;
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

        // ĳ������ ��ġ�� �ڱ� �ڽ��� �Ÿ��� 2.5���� �۴ٸ� 
        if (Vector3.Distance(character.transform.position, transform.position) <= 2.5f)
        {
            agent.isStopped = true; 

            transform.LookAt(direction);
                      
            animator.SetBool("Attack", true);

            if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {           
                if (animator.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {
                    character.GetComponent<Control>().health -= 10;

                    animator.Play("Attack", -1, 0f);
                }
            }
        }
        else // ĳ������ ��ġ�� �ڱ� �ڽ��� �Ÿ��� 2.5���� �־����ٸ�
        {
            agent.isStopped = false;
            animator.SetBool("Attack", false);
        }
    }
}
