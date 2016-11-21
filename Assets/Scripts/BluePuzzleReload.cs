using UnityEngine;
using System.Collections;

public class BluePuzzleReload : MonoBehaviour {

    public Transform puzzleLocation;

    public GameObject puzzleToLoad;
    private GameObject puzzleToDestroy;

    public string destroyThisPuzzl;

	void Update()
    {
        puzzleToDestroy = GameObject.FindGameObjectWithTag (destroyThisPuzzl);
        //Debug.Log(puzzleToDestroy.tag);

    }

	void OnTriggerEnter (Collider collided) {

        if (collided.tag == "Player")
        {

            Destroy (puzzleToDestroy);
            Instantiate(puzzleToLoad, puzzleLocation.transform.position, puzzleLocation.transform.rotation);

        }
	}
}
