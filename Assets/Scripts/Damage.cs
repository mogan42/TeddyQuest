using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Damage : MonoBehaviour {
    /*
     checks for enemy tag
     if collides with enemy 
     make damage counter = 1; and flash screen a hex colour, and add increase the alpha value to the canvas
     if collides again make damage counter = 2;
     */
    public float Lives = 3;
    public float damageCooldown = 1.0f;
    public GameObject Spawnpoint;
    int DamageTaken;
    public string EnemyTag = "enemy";
    public RawImage CanvasOfDamageUI;
    public string HexColour;
    float AlphaValue;
    public Canvas DeadScreen;
    Collision col;

    private float damageTimer = 0;

    // Use this for initialization
    void Start ()
    {
        DamageTaken = 0;
        AlphaValue = 0;
        DeadScreen.gameObject.SetActive(false);
        Spawnpoint.transform.position = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        damageTimer -= Time.deltaTime;

        if (damageTimer <= 0)
        {
            var collider = GetComponent<CapsuleCollider>();
            var top = transform.TransformPoint(collider.center + new Vector3(0, collider.height / 2, 0));
            var bottom = transform.TransformPoint(collider.center - new Vector3(0, collider.height / 2, 0));
            var hits = Physics.OverlapCapsule(top, bottom, collider.radius);

            foreach (Collider c in hits)
            {
                if (c.gameObject.tag == EnemyTag)
                {
                    Debug.Log("Hit: " + c.gameObject.name);
                    DamageTaken++;
                    AlphaValue = ((DamageTaken/Lives + 1 /Lives) * 255)/255;
                    CanvasOfDamageUI.color = new Vector4(1, 0, 0, AlphaValue);
                    Debug.Log("Damage taken: " + DamageTaken);
                    Debug.Log("alpha taken: " + AlphaValue);
                    damageTimer = damageCooldown;
                    break;
                }
            }
        }
        if(DamageTaken == Lives)
        {
            Time.timeScale = 0;
            DamageTaken = 0;
            AlphaValue = ((DamageTaken / Lives) * 255) / 255;
            CanvasOfDamageUI.color = new Vector4(1, 1, 1, AlphaValue);
            DeadScreen.gameObject.SetActive(true);

        }
    }

}
