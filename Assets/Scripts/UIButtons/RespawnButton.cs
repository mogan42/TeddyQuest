using UnityEngine;
using System.Collections;

public class RespawnButton : MonoBehaviour
{
    //put public variable spawnpoint and just use that
    public GameObject Spawner;
    public GameObject player;
    public Canvas canvas;

	// Update is called once per frame
	public void Respawn ()
    {
        canvas.gameObject.SetActive(false);
        player.transform.position = Spawner.transform.position;
        Time.timeScale = 1;
    }
}
