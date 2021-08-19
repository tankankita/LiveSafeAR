using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    private enum Direction {Forward, Right, Left, Backward};
    private Direction direction;

    [SerializeField] private float speed;
    [SerializeField] private GameObject targetWaypoint;
    private bool moving;

    public static PlayerMovementController instance;

    // Start is called before the first frame update
    void Start()
    {
      if (instance == null) {
        instance = this;
      } else {
        Destroy(gameObject);
      }

      direction = Direction.Forward;
      moving = true;
    }

    // Update is called once per frame
    void Update()
    {

      if (moving) {

        //Check if within target range
        if (Vector3.Distance( new Vector3(transform.position.x, 0, transform.position.z), new Vector3(targetWaypoint.transform.position.x, 0, targetWaypoint.transform.position.z)) < 0.3f) {
          moving = false;
          PlayerMovementUIController.instance.EnableUI(targetWaypoint);
        }

        //Move towards target
        else {
          transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(targetWaypoint.transform.position.x, transform.position.y, targetWaypoint.transform.position.z), speed * Time.deltaTime);

          Vector3 diff = targetWaypoint.transform.position - transform.position;
          transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(diff.x, 0, diff.z)), 0.15F);
        }
      }

    }

    public GameObject GetTargetWaypoint() {
      return targetWaypoint;
    }

    public bool IsForwardDirection() {
      if (direction == Direction.Forward) {
        return true;
      }
      return false;
    }

    public bool IsLeftDirection() {
      if (direction == Direction.Left) {
        return true;
      }
      return false;
    }

    public bool IsRightDirection() {
      if (direction == Direction.Right) {
        return true;
      }
      return false;
    }

    public bool IsBackwardDirection() {
      if (direction == Direction.Backward) {
        return true;
      }
      return false;
    }

    public void SetNextWaypoint(GameObject waypoint) {
      targetWaypoint = waypoint;
      moving = true;
      PlayerMovementUIController.instance.DisableUI();
    }
}
