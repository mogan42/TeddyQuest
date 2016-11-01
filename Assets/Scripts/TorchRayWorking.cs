using UnityEngine;
using System.Collections;

public class TorchRayWorking : MonoBehaviour
{
    public float torchWidth = 20f;
    public float torchLength = 10f;
    public bool enemyInLight;
    public Rigidbody rb1;

    public Rigidbody rb2;
    public Rigidbody rb3;
    Vector3 frozenPosition;


    private GameObject enemy;


    void Update()
    {
        var enemies1 = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject e1 in enemies1)
        {
            var enemy = e1.GetComponent<WanderingAI>();
            enemy.InLight = false;
            Vector3 direction = e1.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.up);
            //Debug.Log(angle);
            if (angle < torchWidth * 0.5f)
            {
                RaycastHit hit;

                if (Physics.Raycast(transform.position, direction.normalized, out hit, torchLength))
                {
                    if (hit.collider.gameObject == e1)
                    {
                        Debug.DrawRay(transform.position, direction.normalized, Color.green);
                        enemyInLight = true;
                        //Debug.Log("Enemy Hit!");

                        enemy.InLight = true;

                    }
                }
            }
        }
    }

}
