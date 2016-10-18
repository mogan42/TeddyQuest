using UnityEngine;
using System.Collections;

public class TorchRay : MonoBehaviour
{
    public KeyCode onSwitch = KeyCode.F;
    public float torchWidth = 20f;
    public float torchLength = 10f;
    public bool enemyInLight;
    public float force = 100f;
    public Rigidbody rb;
    public Rigidbody rbb;
    public Rigidbody rbbb;
    bool lightOn = false;
   




    private GameObject enemy;

    void Update()
    {
        if(Input.GetKey(onSwitch))
        {
            if (lightOn == false)
            {
                lightOn = true;
            }
            else if (lightOn == true)
            {
                lightOn = false;
            }
        }
        if (lightOn == true)
        { 
            var enemies = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject e in enemies)
            {

                Vector3 direction = e.transform.position - transform.position;
                float angle = Vector3.Angle(direction, transform.up);
                Debug.Log(angle);

                if (angle > torchWidth * 0.5f)
                {
                    Defrost();
                }
                   // Debug.Log("Width = " + torchWidth);
                    if (angle < torchWidth * 0.5f)
                    {
                        RaycastHit hit;

                        if (Physics.Raycast(transform.position + transform.up * 0.5f, direction.normalized, out hit, torchLength))
                        {
                            if (hit.collider.gameObject == e)
                            {
                                Debug.DrawRay(transform.position + transform.up * 0.5f, direction.normalized, Color.green);
                                enemyInLight = true;
                                // Debug.Log("Enemy Hit!");
                                // hit.rigidbody.AddForce(force * transform.up);
                                Freeze();

                            }

                        }
                }
            }
        }
    }
    void Freeze()
    {
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        rbb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        rbbb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
    }

    void Defrost()
    {
        if(enemyInLight == false)
        {
            rb.constraints = RigidbodyConstraints.None;
            rbb.constraints = RigidbodyConstraints.None;
            rbbb.constraints = RigidbodyConstraints.None;
        }
    }

}
