using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour
{
    private NavMeshAgent m_agent;
	// Use this for initialization
	void Start ()
    {
        m_agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (Input.GetMouseButtonDown (0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit))
            {
                m_agent.destination = hit.point;
            }
        }
	}
}
