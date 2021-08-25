// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_UIAudioPlay : MonoBehaviour
{
    [Header("Object with Audio Source")]
    public AudioSource audioSource;

    [Header("Wait time to Play Audio")]
    public float seconds;

    [Header("Check Box Keyframe Animation")]
    public bool playAudio;



    // Start is called before the first frame update
    void Start()
    {
    }

    public void Update()
    {
        StartCoroutine(AudioSourcePlay());  
    }

    public void OnMouseDown()
    {
        playAudio = true;
        StartCoroutine(AudioSourcePlay());
        playAudio = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        AudioSourcePlay();
    }

    public void OnCollisionEnter(Collision collision)
    {
        AudioSourcePlay();
    }

    IEnumerator AudioSourcePlay()
    {
        yield return new WaitForSecondsRealtime(seconds);
        if (playAudio == true)
        {
            audioSource.Play();
            Debug.Log(audioSource + "is Playing");
        }
    }
}

