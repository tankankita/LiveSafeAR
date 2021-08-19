using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementUIController : MonoBehaviour
{
    [SerializeField] private Button forwardButton;
    [SerializeField] private Button leftButton;
    [SerializeField] private Button rightButton;
    [SerializeField] private Button backwardButton;

    private bool forwardButtonEnabled = true;
    private bool leftButtonEnabled = true;
    private bool rightButtonEnabled = true;
    private bool backwardButtonEnabled = true;
    // private bool disableUI;

    public static PlayerMovementUIController instance;

    void Start()
    {
      if (instance == null) {
        instance = this;
      } else {
        Destroy(gameObject);
      }

      DisableUI();
      // disableUI = true;
    }


    public void EnableUI (GameObject waypoint) {
      // disableUI = false;

      if (waypoint.GetComponent<WaypointController>().IsForwardValid()) {
        forwardButton.interactable = true;
      }

      if (waypoint.GetComponent<WaypointController>().IsLeftValid()) {
        leftButton.interactable = true;
      }

      if (waypoint.GetComponent<WaypointController>().IsRightValid()) {
        rightButton.interactable = true;
      }

      if (waypoint.GetComponent<WaypointController>().IsBackwardValid()) {
        backwardButton.interactable = true;
      }
    }

    public void DisableUI () {
      // disableUI = true;
      forwardButton.interactable = false;
      leftButton.interactable = false;
      rightButton.interactable = false;
      backwardButton.interactable = false;
    }

    /*BUTTON FUNCTIONS*/

    //Forward Button Clicked
    public void ForwardButton() {

      //Check if UI is disabled for user movement
      // if (!disableUI) {

        GameObject waypoint = PlayerMovementController.instance.GetTargetWaypoint();

        //Player facing forward
        if (PlayerMovementController.instance.IsForwardDirection()) {

          //Check if button is valid
          if (forwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetForwardWaypoint());
          }
        }

        //Player facing to the left
        else if (PlayerMovementController.instance.IsLeftDirection()) {

          //Check if button is valid
          if (leftButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetLeftWaypoint());
          }
        }

        //Player facing to the right
        else if (PlayerMovementController.instance.IsRightDirection()) {

          //Check if button is valid
          if (rightButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetRightWaypoint());
          }
        }

        //Player facing backwards
        else if (PlayerMovementController.instance.IsBackwardDirection()) {

          //Check if button is valid
          if (backwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetBackwardWaypoint());
          }
        }
      // }
    }


    //Right Button Clicked
    public void RightButton() {

      //Check if UI is disabled for user movement
      // if (!disableUI) {

        GameObject waypoint = PlayerMovementController.instance.GetTargetWaypoint();

        //Player facing forward
        if (PlayerMovementController.instance.IsForwardDirection()) {

          //Check if button is valid
          if (rightButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetRightWaypoint());
          }
        }

        //Player facing to the left
        else if (PlayerMovementController.instance.IsLeftDirection()) {

          //Check if button is valid
          if (forwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetForwardWaypoint());
          }
        }

        //Player facing to the right
        else if (PlayerMovementController.instance.IsRightDirection()) {

          //Check if button is valid
          if (backwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetBackwardWaypoint());
          }
        }

        //Player facing backwards
        else if (PlayerMovementController.instance.IsBackwardDirection()) {

          //Check if button is valid
          if (leftButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetLeftWaypoint());
          }
        }
      // }
    }


    //Left Button Clicked
    public void LeftButton() {

      //Check if UI is disabled for user movement
      // if (!disableUI) {

        GameObject waypoint = PlayerMovementController.instance.GetTargetWaypoint();

        //Player facing forward
        if (PlayerMovementController.instance.IsForwardDirection()) {

          //Check if button is valid
          if (leftButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetLeftWaypoint());
          }
        }

        //Player facing to the left
        else if (PlayerMovementController.instance.IsLeftDirection()) {

          //Check if button is valid
          if (backwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetBackwardWaypoint());
          }
        }

        //Player facing to the right
        else if (PlayerMovementController.instance.IsRightDirection()) {

          //Check if button is valid
          if (forwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetForwardWaypoint());
          }
        }

        //Player facing backwards
        else if (PlayerMovementController.instance.IsBackwardDirection()) {

          //Check if button is valid
          if (rightButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetRightWaypoint());
          }
        }
      // }
    }


    //Back Button Clicked
    public void BackwardButton() {

      //Check if UI is disabled for user movement
      // if (!disableUI) {

        GameObject waypoint = PlayerMovementController.instance.GetTargetWaypoint();

        //Player facing forward
        if (PlayerMovementController.instance.IsForwardDirection()) {

          //Check if button is valid
          if (backwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetBackwardWaypoint());
          }
        }

        //Player facing to the left
        else if (PlayerMovementController.instance.IsLeftDirection()) {

          //Check if button is valid
          if (rightButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetRightWaypoint());
          }
        }

        //Player facing to the right
        else if (PlayerMovementController.instance.IsRightDirection()) {

          //Check if button is valid
          if (leftButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetLeftWaypoint());
          }
        }

        //Player facing backwards
        else if (PlayerMovementController.instance.IsBackwardDirection()) {

          //Check if button is valid
          if (forwardButtonEnabled) {
            PlayerMovementController.instance.SetNextWaypoint(waypoint.GetComponent<WaypointController>().GetForwardWaypoint());
          }
        }
      // }
    }

}
