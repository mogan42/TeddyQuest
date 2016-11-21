using UnityEngine;
using System.Collections;

public class RandomNumberTest : MonoBehaviour
{
    private float soundInt;
    private float rndNum = Random.Range(1, 30);
    private float soundTrigger = 0;

	
    void Start()
    {
        soundInt = rndNum;
    }

	void Awake()
    {
        Debug.Log(rndNum);
        Debug.Log(soundInt);
    }
	

	void Update()
    {
        soundTrigger += Time.deltaTime;

        if(soundTrigger == soundInt)
        {
            Debug.Log("play sound");
        }
	}
}
