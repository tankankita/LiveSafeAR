// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRTerra_XRMovingPlatform : MonoBehaviour
{
    [Header("Reference XR Rig Parent")]
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
