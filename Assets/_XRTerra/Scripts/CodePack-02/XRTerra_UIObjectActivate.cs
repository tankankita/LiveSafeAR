// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_UIObjectActivate : MonoBehaviour
{
    public GameObject objectToActivate;
    [Header("Wait time to Activate")]
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        StartCoroutine(ActivateObject());
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ActivateObject());
    }

    public void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ActivateObject());
    }

    IEnumerator ActivateObject()
    {
        yield return new WaitForSecondsRealtime(seconds);
        objectToActivate.SetActive(true); ;
        Debug.Log(objectToActivate + "is Active");
    }
}
