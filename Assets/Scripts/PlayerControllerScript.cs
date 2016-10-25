//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;

//public class PlayerControllerScript : MonoBehaviour {

//    GameObject mainCamera;

//    GameObject objectToDestroy;

//    public Text useKey;
//    public Text lootScoreUI;
//    public Text healthUI;

//    public AudioClip lootChime;
//    AudioSource audio;

//    public int lootScore;
//    public int health;




//    private bool canPressE = false;

//	// Use this for initialization
//	void Start () {
//        mainCamera = GameObject.FindWithTag("MainCamera");
//        useKey.enabled = false;
//        audio = GetComponent<AudioSource>();
//    }
	
//	// Update is called once per frame
//	void Update () {
//        lootScoreUI.text = "Loot: $" + lootScore;
//        healthUI.text = "Health:" + health;
//    }

//    void OnTriggerStay(Collider other) {
//        if (other.tag == "Pickup") {
//            FireRay();
//            if (canPressE) {
//                useKey.enabled = true;
//                if (Input.GetKey(KeyCode.E)) {
//                    pickupValue loot = other.gameObject.GetComponent<pickupValue>();
//                    lootScore += loot.value;
//                    Destroy(objectToDestroy);
//                    useKey.enabled = false;
//                    audio.PlayOneShot(lootChime, 0.7f);
//                }
//            }
//            else useKey.enabled = false;
//        }
//    }

//    void OnTriggerExit(Collider other) {
//        if (other.tag == "Pickup") {
//            useKey.enabled = false;
//        }
//    }

//    void FireRay() {
//        int x = Screen.width / 2;
//        int y = Screen.height / 2;

//        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));

//        RaycastHit hit;
//        if (Physics.Raycast(ray, out hit)) {
//            if (hit.distance <= 4) {
//                if (hit.collider.gameObject.tag == "Pickup") {
//                    //get the game object
//                    objectToDestroy = hit.collider.gameObject;
//                    canPressE = true;
//                    //debugs to make sure script is working
//                    Debug.DrawLine(transform.position, hit.transform.position, Color.green);
//                } else { canPressE = false; }
//            } else { canPressE = false; }
//        } else { canPressE = false; }
//    }
//}
