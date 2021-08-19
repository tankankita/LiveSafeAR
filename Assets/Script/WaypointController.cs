using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{

    [SerializeField] private GameObject forwardWaypoint;
    [SerializeField] private GameObject leftWaypoint;
    [SerializeField] private GameObject rightWaypoint;
    [SerializeField] private GameObject backwardWaypoint;


    public GameObject GetForwardWaypoint() {

      return forwardWaypoint;
    }

    public GameObject GetLeftWaypoint() {

      return leftWaypoint;
    }

    public GameObject GetRightWaypoint() {

      return rightWaypoint;
    }

    public GameObject GetBackwardWaypoint() {

      return backwardWaypoint;
    }


    public bool IsForwardValid() {
      if (forwardWaypoint) {
        return true;
      }

      return false;
    }

    public bool IsLeftValid() {
      if (leftWaypoint) {
        return true;
      }

      return false;
    }

    public bool IsRightValid() {
      if (rightWaypoint) {
        return true;
      }

      return false;
    }

    public bool IsBackwardValid() {
      if (backwardWaypoint) {
        return true;
      }

      return false;
    }
}
