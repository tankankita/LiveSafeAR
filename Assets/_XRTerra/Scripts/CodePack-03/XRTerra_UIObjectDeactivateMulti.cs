// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_UIObjectDeactivateMulti : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void OnMouseDown()
    {

        for (int i = 0; i < objectsToDeactivate.Length; i++)
        {
            objectsToDeactivate[i].SetActive(false);
        }

    }
    public void DeactivateMultiObject()
    {

        for (int i = 0; i < objectsToDeactivate.Length; i++)
        {
            objectsToDeactivate[i].SetActive(false);
        }

    }
}
