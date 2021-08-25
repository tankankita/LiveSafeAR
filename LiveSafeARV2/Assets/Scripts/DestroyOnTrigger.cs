using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public string tagToTrigger;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagToTrigger))
        {
            // What else needs to happen before destroy

            Destroy(gameObject);
        }
    }
}
