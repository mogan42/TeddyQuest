using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Damage : MonoBehaviour {
   
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
    bool IsDead;

    private float damageTimer = 0;

    // Use this for initialization
    void Start ()
    {
        DamageTaken = 0;
        AlphaValue = 0;
        DeadScreen.gameObject.SetActive(false);
        IsDead = false;
        Spawnpoint.transform.position = transform.position;
    }
	public bool DeathChecker()
    {
        return IsDead;
    }

    public void Respawn()
    {
        DeadScreen.gameObject.SetActive(false);
        transform.position = Spawnpoint.transform.position;
        Time.timeScale = 1;
        IsDead = false;
        DamageTaken = 0;
        AlphaValue = ((DamageTaken / Lives) * 255) / 255;
        CanvasOfDamageUI.color = new Vector4(1, 1, 1, AlphaValue);
        Cursor.lockState = CursorLockMode.Locked;
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
                    //Debug.Log("Damage taken: " + DamageTaken);
                    //Debug.Log("alpha taken: " + AlphaValue);
                    damageTimer = damageCooldown;
                    break;
                }
            }
        }
        if(DamageTaken == Lives)
        {
            Time.timeScale = 0;
            DeadScreen.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            IsDead = true;
            Debug.Log(IsDead);
        }
    }
    

}
