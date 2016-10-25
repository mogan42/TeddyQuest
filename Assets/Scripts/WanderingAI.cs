using UnityEngine;
using System.Collections;

public class WanderingAI : MonoBehaviour
{
    /*check if player is within range.
    if player is run straight to them, 
    else wander(get a
    */
    public float searchRadius= 50;
    public float roamRadius = 10;
    public GameObject player;
    private NavMeshAgent m_agent;
    bool chaseable = false;
    bool EnemyInLight = false;
    float distanceFromPlayer;
    float distanceFromPosition;
    Vector3 randomDirection;


    // Use this for initialization
    void Start ()
    {
        m_agent = GetComponent<NavMeshAgent>();
        randomDirection = Random.insideUnitSphere * roamRadius * Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update ()
    {
        distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceFromPlayer <= searchRadius)
        {
            chaseable = true;
            Debug.Log("player is in range");
        }
        else if (distanceFromPlayer > searchRadius)
        {
            chaseable = false;
            Debug.Log("player is not in range");
        }
        if (chaseable && !EnemyInLight)
        {
            Chase();
        }
        else if (!chaseable)
        {
            Wander();
        }

    }

    void Chase()
    {
        if (EnemyInLight)
        {
            m_agent.destination = m_agent.transform.position;
        }
        else
        {
            m_agent.destination = player.transform.position;
        }
    }
    void Wander()
    {
        distanceFromPosition = Vector3.Distance(transform.position, m_agent.destination);
       if (distanceFromPosition <= 1)
        {
           randomDirection = Random.insideUnitSphere * roamRadius;
        }
        Debug.Log(distanceFromPosition);
        Debug.Log("I need to wander");
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, roamRadius, 1);
        Vector3 finalPosition = hit.position;
        m_agent.destination = finalPosition;
    }
}
