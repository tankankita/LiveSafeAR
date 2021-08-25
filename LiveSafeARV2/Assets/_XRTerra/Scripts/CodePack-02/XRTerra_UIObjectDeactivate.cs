// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_UIObjectDeactivate : MonoBehaviour
{
    public GameObject objectToDeactivate;
    [Header("Wait time to Activate")]
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        StartCoroutine(DeactivateObject());
    }

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(DeactivateObject());
    }

    public void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(DeactivateObject());
    }

    IEnumerator DeactivateObject()
    {
        yield return new WaitForSecondsRealtime(seconds);
        objectToDeactivate.SetActive(false); ;
        Debug.Log(objectToDeactivate + "is Inactive");
    }

}
