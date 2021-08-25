using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationListener : MonoBehaviour
{
    public NotificationTrigger[] notificationTriggers;
    public Animator notificationBar;
    public Text notificationText;

    // Start is called before the first frame update
    void Start()
    {
        if (notificationTriggers.Length > 0)
        {
            foreach (NotificationTrigger trigger in notificationTriggers)
            {
                trigger.EnterNotificationEvent += OnZoneEnter;
                //trigger.ExitNotificationEvent += OnZoneExit;
            }
        }
    }

    public void OnZoneEnter(string txt)
    {
        notificationText.text = txt;
        notificationBar.SetTrigger("ShowNotification");

        // add here what else needs to happen when zone entered
    }

    /*
    public void OnZoneExit(string txt)
    {
        notificationText.text = txt;
        notificationBar.SetTrigger("ShowNotification");

        // add here what else needs to happen when zone exited
    }
    */
}
