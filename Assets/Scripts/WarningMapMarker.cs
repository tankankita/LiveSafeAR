using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningMapMarker : MonoBehaviour
{
    private float floodStartTimer = SafetyAlert.GetFloodStartTimer();

    public float _movementTimer = 1;

    private int timer = 0;

    private bool _destinationReached = false;




    void MarkerMoveUp() 
    {
      Vector3 startingPos  = transform.position;
      Vector3 finalPos = transform.position + (transform.up * 0.05f);
      float elapsedTime = 0;

      while (elapsedTime < _movementTimer) 
      {
         transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / _movementTimer));
         elapsedTime += Time.deltaTime;
      }
    }

    void MarkerMoveDown() 
    {
      Vector3 startingPos  = transform.position;
      Vector3 finalPos = transform.position + (-transform.up * 0.05f);
      float elapsedTime = 0;

      while (elapsedTime < _movementTimer) {
         transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / _movementTimer));
         elapsedTime += Time.deltaTime;
      }
    }



    void OnTriggerEnter()
    {
     _destinationReached = true;   
    }

    void Update()
    {
        timer +=1;
        if (timer >= floodStartTimer & !_destinationReached)
        {
            MarkerMoveUp();
        }

        if (_movementTimer >= floodStartTimer & _destinationReached)
        {
            MarkerMoveDown();
        }

    }
}

