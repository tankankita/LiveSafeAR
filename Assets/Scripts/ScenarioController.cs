using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ScenarioController : MonoBehaviour
{

    [SerializeField]
    private float walkSafeTimer;

    [SerializeField]
    private float floodTimer;

    private float displayTimer;
    private float displayMinutes;
    private float displaySeconds;

    private bool destinationReached;

    [SerializeField]
    private TextMeshProUGUI floodDisplayTimer;

    [SerializeField]
    private GameObject safeWalkOkMessage;

    [SerializeField]
    private GameObject floodWarningMessage;

    [SerializeField]
    private GameObject safeMessage;

    [SerializeField]
    private GameObject sweptAwayMessage;


    // Start is called before the first frame update
    void Start()
    {

      int scenario = PlayerPrefs.GetInt("selectedScenario");

      if (scenario == 0) {
        OnWalkSafeScenerioStart();
      }

      if (scenario == 1) {
        OnFloodScenerioStart();
      }
    }

    //Update Flood Timer
    void Update() {

      if (floodDisplayTimer.gameObject.active) {

          //Update Timer
          displayTimer -= Time.deltaTime;
          displayMinutes = Mathf.Floor(displayTimer / 60f);
          displaySeconds = displayTimer % 60f;

          if (displaySeconds > 60){
            displaySeconds = 59;
          }

          if (displayTimer > 0) {
            floodDisplayTimer.text = string.Format("{0:0}:{1:00}", displayMinutes, displaySeconds);
          }

          if (displayTimer < 0) {
            Debug.Log("Times Up");
          }
      }

    }

    //Called when destination collider is entered or exited
    public void SetDestonationReached(bool value) {
      destinationReached = value;

      if (true) {
        Debug.Log("Destination Reached");
        safeMessage.SetActive(true);
        floodDisplayTimer.gameObject.SetActive(false);
      } else {
        safeMessage.SetActive(false);
      }
    }


    //TODO: Needs to be called
    //Reset when scenario is finished
    public void Reset() {
      floodDisplayTimer.gameObject.SetActive(false);
      safeWalkOkMessage.SetActive(false);
      floodWarningMessage.SetActive(false);
      safeMessage.SetActive(false);
      sweptAwayMessage.SetActive(false);
    }


    //WALK SAFE SCENARIO
    public void OnWalkSafeScenerioStart() {
      StartCoroutine("SafeWalkOkTimer");
    }

    //Coroutine Timer based on walkSafeTimer
    private IEnumerator SafeWalkOkTimer() {

      yield return new WaitForSeconds(walkSafeTimer);

      if (!destinationReached) {
        safeWalkOkMessage.SetActive(true);
      }
    }


    //FLOOD SCENARIO
    public void OnFloodScenerioStart() {
      displayTimer = floodTimer;
      floodWarningMessage.SetActive(true);
      floodDisplayTimer.gameObject.SetActive(true);
      StartCoroutine("FloodWarningTimer");
      StartCoroutine("FloodArival");
    }

    private IEnumerator FloodWarningTimer() {

       yield return new WaitForSeconds(floodTimer/2);

       if (!destinationReached) {
         floodWarningMessage.SetActive(true);
       }
    }

    private IEnumerator FloodArival() {

      yield return new WaitForSeconds(floodTimer);

      if (!destinationReached) {
        sweptAwayMessage.SetActive(true);
      }
    }
}
