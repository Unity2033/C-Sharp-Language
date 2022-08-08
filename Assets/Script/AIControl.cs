using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    private NavMeshAgent agent;

    [SerializeField] Transform[ ] Waypoint;

    private int count;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating(nameof(MoveNext), 0, 2);
    }

    public void MoveNext()
    {
        if(agent.velocity == Vector3.zero)
        {
            agent.SetDestination(Waypoint[count++].position);

            if(count >= Waypoint.Length)
            {
                count = 0;
            }
        }
    }

    void Update()
    {
        
    }
}
