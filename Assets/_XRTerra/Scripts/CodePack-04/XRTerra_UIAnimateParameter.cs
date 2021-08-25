// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_UIAnimateParameter : MonoBehaviour
{
    [Header("Parent Object with Animator")]
    public Animator objectToAnimate;

    [Header("Wait time to Play Animation")]
    public float seconds;

    [Header("Animator Transition Paramater")]
    public string parameterName;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnMouseDown()
    {
        StartCoroutine(AnimationTriggerPlay());
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(AnimationTriggerPlay());
    }

    public void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(AnimationTriggerPlay());
    }

    IEnumerator AnimationTriggerPlay()
    {
        yield return new WaitForSecondsRealtime(seconds);
        objectToAnimate.SetTrigger(parameterName);
        Debug.Log(parameterName + "is Playing");
    }

}
