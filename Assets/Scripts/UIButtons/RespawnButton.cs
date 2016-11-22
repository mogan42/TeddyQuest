using UnityEngine;
using System.Collections;

public class RespawnButton : MonoBehaviour
{
    //put public variable spawnpoint and just use that
    public Damage damage;

	// Update is called once per frame
	public void Respawn ()
    {
        damage.Respawn();

    }
}
