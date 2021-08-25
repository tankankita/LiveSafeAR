// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_UIAnimate : MonoBehaviour
{
    [Header("Parent Object with Animator")]
    public Animator objectToAnimate;

    [Header("Wait time to Play Animation")]
    public float seconds;

    [Header("Specific Animation Name")]
    public string animationName;


    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnMouseDown()
    {
        StartCoroutine(AnimationPlay());
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(AnimationPlay());
    }

    public void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(AnimationPlay());
    }

    IEnumerator AnimationPlay()
    {
        yield return new WaitForSecondsRealtime(seconds);
        objectToAnimate.Play(animationName);
        Debug.Log(animationName + "is Playing");
    }
}
