using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void EnterNotificationDelegate(string name);
public delegate void ExitNotificationDelegate(string name);

public class NotificationTrigger : MonoBehaviour
{
    public EnterNotificationDelegate EnterNotificationEvent;
    //public ExitNotificationDelegate ExitNotificationEvent;

    public string zoneEnterText;
    public string tagToCheck;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagToCheck))
        {
            EnterNotificationEvent(zoneEnterText);
        }
    }

    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(tagToCheck))
        {
            ExitNotificationEvent(zoneEnterText);
        }
    }
    */
}
