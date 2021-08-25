// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_UIObjectActivateMulti : MonoBehaviour
{
    public GameObject[] objectsToActivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void OnMouseDown()
    {

        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(true);
        }

    }

    public void ActivateMultiObject()
    {

        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(true);
        }

    }
}
