using UnityEngine;
using System.Collections;

public class GlobalLog : MonoBehaviour {

    public static GlobalLog Instance;

    public bool caveExit;
    public bool vegForestExit;
    public bool amazonLibraryExit;
    public bool childsRoomExit;

    public int numberOfKeys;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

}
