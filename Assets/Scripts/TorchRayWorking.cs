using UnityEngine;
using System.Collections;

public class TorchRayWorking : MonoBehaviour
{
    public float torchWidth = 20f;
    public float torchLength = 10f;
    public bool enemyInLight;
    public float force = 100f;
    public Rigidbody rb1;
    public Rigidbody rb2;
    public Rigidbody rb3;

    private GameObject enemy;

    //void Start()
    //{
    //    enemyInLight = false;
    //}

    void Update()
    {
        var enemies1 = GameObject.FindGameObjectsWithTag("enemy1");
        foreach(GameObject e1 in enemies1)
        {
            Vector3 direction = e1.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.up);
            Debug.Log(angle);
            // Debug.Log("Width = " + torchWidth);
            if(angle < torchWidth * 0.5f)
            {
                RaycastHit hit;

                if(Physics.Raycast(transform.position, direction.normalized, out hit, torchLength))
                {
                    if(hit.collider.gameObject == e1)
                    {
                        Debug.DrawRay(transform.position, direction.normalized, Color.green);
                        enemyInLight = true;
                        //Debug.Log("Enemy Hit!");
                        //hit.rigidbody.AddForce(force * transform.up);
                     
                            Freeze1();
                        
                    }
                }
            }
            if(angle > torchWidth * 0.5f)
            {
                enemyInLight = false;
              
                    Defrost1();
                  
            }
        }

        var enemies2 = GameObject.FindGameObjectsWithTag("enemy2");
        foreach (GameObject e2 in enemies2)
        {
            Vector3 direction = e2.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.up);
            Debug.Log(angle);
            // Debug.Log("Width = " + torchWidth);
            if (angle < torchWidth * 0.5f)
            {
                RaycastHit hit;

                if (Physics.Raycast(transform.position, direction.normalized, out hit, torchLength))
                {
                    if (hit.collider.gameObject == e2)
                    {
                        Debug.DrawRay(transform.position, direction.normalized, Color.green);
                        enemyInLight = true;
                        //Debug.Log("Enemy Hit!");
                        //hit.rigidbody.AddForce(force * transform.up);
                
                        
                            Freeze2();
                        
                    }
                }
            }
            if (angle > torchWidth * 0.5f)
            {
                enemyInLight = false;
            
                    Defrost2();
                
            }
        }

        var enemies3 = GameObject.FindGameObjectsWithTag("enemy3");
        foreach (GameObject e3 in enemies3)
        {
            Vector3 direction = e3.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.up);
            Debug.Log(angle);
            // Debug.Log("Width = " + torchWidth);
            if (angle < torchWidth * 0.5f)
            {
                RaycastHit hit;

                if (Physics.Raycast(transform.position, direction.normalized, out hit, torchLength))
                {
                    if (hit.collider.gameObject == e3)
                    {
                        Debug.DrawRay(transform.position, direction.normalized, Color.green);
                        enemyInLight = true;
                        //Debug.Log("Enemy Hit!");
                        //hit.rigidbody.AddForce(force * transform.up);
                      
                            Freeze3();
                        
                    }
                }
            }
            if (angle > torchWidth * 0.5f)
            {
                enemyInLight = false;
        
                    Defrost3();
                
            }
        }
    }
    void Freeze1()
    {
        if(enemyInLight == true)
        {
            rb1.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        }
    }

    void Freeze2()
    {
        if(enemyInLight == true)
        {
            rb2.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        }
    }

    void Freeze3()
    {
        if(enemyInLight == true)
        {
            rb3.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        }
    }

    void Defrost1()
    {
        if(enemyInLight == false)
        {
            rb1.constraints = RigidbodyConstraints.None;
        }
    }

    void Defrost2()
    {
        if (enemyInLight == false)
        {
            rb2.constraints = RigidbodyConstraints.None;
        }
    }

    void Defrost3()
    {
        if (enemyInLight == false)
        {
            rb3.constraints = RigidbodyConstraints.None;
        }
    }

}
