// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class XRTerra_SceneChanger : MonoBehaviour
{
    [Header(" Number for Click Interaction")]
    public int sceneNumber; // Use this FUNCTION for an INTERACTION with a UNITY TRIGGER COLLIDER

    [ Header ("Tag for Object Interaction") ]
    public string objectTag; // Use this FUNCTION for an INTERACTION with a UNITY TRIGGER COLLIDER

    [Header(" Time to Load Scene")]
    public float seconds;

    // Keep start in your hierarchy to enable or disable this script through the inspector and animation windows 
    void Start()
    {
    }

    public void SceneToChange(int sceneNumber) // Use this FUNCTION for an INTERACTION set up with Unity UI or the XR TOOLKIT
    {
        SceneManager.LoadScene(sceneNumber);
    }
    public void OnMouseDown() // Use this FUNCTION for an INTERACTION set up with Unity Mouse Interactions or Mobile
    {
        StartCoroutine(SceneLoadWaitTime());
    }

    public void OnTriggerEnter(Collider collider) // Use this FUNCTION for an INTERACTION with a UNITY TRIGGER COLLIDER
    {
        if (collider.tag == objectTag)
        {
            StartCoroutine(SceneLoadWaitTime()); 
        }
    }

    IEnumerator SceneLoadWaitTime()
    {
        yield return new WaitForSecondsRealtime(seconds);
        SceneManager.LoadScene(sceneNumber);
    }
}
