using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationController : MonoBehaviour
{

    public GameObject scenarioController;

    private void OnTriggerEnter(Collider col) {
      if (col.gameObject.tag == "Player") {
        scenarioController.GetComponent<ScenarioController>().SetDestonationReached(true);
      }
    }

    private void OnTriggerExit(Collider col) {
      if (col.gameObject.tag == "Player") {
        scenarioController.GetComponent<ScenarioController>().SetDestonationReached(false);
      }
    }
}
