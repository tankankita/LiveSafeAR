// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_ObjectPositionUpdate : MonoBehaviour
{
    public GameObject positionReference;
    private Vector3 referencePosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        referencePosition = positionReference.transform.position;
        transform.position = referencePosition;
    }
}
