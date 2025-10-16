using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public NavMeshAgent agent;

    private void Start()
    {
        InvokeRepeating("Move", 1f, 2f);
    }

    private void Move()
    {
        float radius = 7f;
        float randX = Random.Range(-radius, radius);
        float randZ = Random.Range(-radius, radius);
        Vector3 moveTo = new Vector3(randX,0,randZ) + transform.position;
        agent.SetDestination(moveTo);
    }
}
