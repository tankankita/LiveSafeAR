using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitApp : MonoBehaviour
{
    
    public AudioSource audioSource;
    public GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        {
            if (audioSource != null)
            {
                if (!audioSource.isPlaying)
                    audioSource.Play();
            }
            Application.Quit();
        }
    }
}
