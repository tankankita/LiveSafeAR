using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationController : MonoBehaviour
{
    public Camera camera;
    public GameObject scenarioController;

    void Update() {
      transform.GetChild(0).gameObject.transform.LookAt(camera.transform.position);
    }

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
