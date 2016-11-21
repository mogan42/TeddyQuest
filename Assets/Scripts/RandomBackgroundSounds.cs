using UnityEngine;
using System.Collections;

public class RandomBackgroundSounds : MonoBehaviour
{
    public AudioClip[] clips;
    public float lowRandomRange;
    public float highRandomRange;

    bool countdownActive = false;

	// Update is called once per frame
	void Start()
    {
        StartCountdown();
    }

    void Update()
    {
        var audio = GetComponent<AudioSource>();
        if (!audio.isPlaying && !countdownActive)
        {
            StartCountdown();
            countdownActive = true;
        }
    }

    void StartCountdown()
    {
        StartCoroutine("waitRandomInt");
    }

    IEnumerator waitRandomInt()
    {
        yield return new WaitForSeconds(Random.Range(lowRandomRange, highRandomRange));
        SmoothBackgroundJazz();
        countdownActive = false;
    }

    public void SmoothBackgroundJazz()
    {
        int clipPick = Random.Range(0, clips.Length);
        var audio = GetComponent<AudioSource>();
        audio.clip = clips[clipPick];
        audio.Play();

    }
}

// StartCoroutine("waitRandomInt");
