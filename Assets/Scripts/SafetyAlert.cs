// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SafetyAlert : MonoBehaviour
// {

//     public int floodStartTimer = 20;

//     public GameObject alertNotifcation;

//     private bool yes, no;

//     private void Start()
//     {
//         Invoke("StartNotification",floodStartTimer);
//     }
    
//     private IEnumerator SafetyCheckupPopup()

//     {

// 	int maxWait = 10;

// 		while (maxWait > 0)
// 	{
// 		yield return new WaitForSeconds(1);
// 		maxWait--;
// 	}

//     if (maxWait <= 0)
//     {
//         alertNotifcation.SetActive(true);
//     } 

//     if (yes)
//     {
//         alertNotifcation.SetActive(false);
//         StartCourtine(SafetyCheckupPopup);
//     }

//     // else if (no)
//     // {
//     //     Call911();
//     // }

//     // }
//     }

//     private void StartNotification()
//     {
//         StartCourtine(SafetyCheckupPopup);
//     }


//     public void Yes()
//     {
//         yes = true;
//         no = false;
//     }

//     public void No()
//     {
//         yes = false;
//         no = true;
//     }

// }
