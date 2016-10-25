using UnityEngine;
using System.Collections;

public class WanderingAI : MonoBehaviour
{
    /*check if player is within range.
    if player is run straight to them, 
    else wander(get a
    */
    public float searchRadius= 50;
    public GameObject player;
    private NavMeshAgent m_agent;
    bool chaseable = false;
    float distanceFromPlayer;


    // Use this for initialization
    void Start ()
    {
        m_agent = GetComponent<NavMeshAgent>();
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
        if (chaseable)
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
        m_agent.destination = player.transform.position;
    }
    void Wander()
    {
        Debug.Log("I need to wander");
    }
}
