using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GPSController : MonoBehaviour
{

    public TextMeshProUGUI GPSCoordsText;

    float lat;
    float lon;



    ##Replace (lat,long) of physical distance with actual values 
    #Vector2 origin = new Vector2 (lat,long);
    #Vector2 right= new Vector2 (lat,long);
    #Vector2 left= new Vector2 (lat,long);
    #Vector2 top= new Vector2 (lat,long);
    #Vector2 bottom= new Vector2 (lat,long); 
    Vector2 coords = new Vector2();




   


    // Start is called before the first frame update
    void Start()
    {
	GPSLocation();
    }

  


    private IEnumerator GPSLocation()
    {
	Input.location.Start();

	int maxWait = 20;

		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
	{
		yield return new WaitForSeconds(1);
		maxWait--;
	}

		if (maxWait <1)
		{
			print("Timed out");
			yield break;
		}
	lat = Input.location.lastData.latitude;
	lon = Input.location.lastData.longitude;
 	Input.location.Stop();
	
    }


    // Update is called once per frame
    void Update()
    {

    Vector3 mapposition = transform.position;

    
 	GPSLocation();

    coords.x = lat;
    coords.y = lon;

    GPSCoordsText.text = "Latitude:" + lat + "\n" + ", Longitude:" + lon;

	if ( right.y > origin.y & left.y < origin.y & top.x > origin.x )
    {
        if ( coords.y > origin.y ) 
            {for (float i = 50; i >= 1; i--)
                if ((coords-origin).magnitude < (right-origin).magnitude/(i))
                {
                    mapposition += transform.right*50f/(i);
                }
            }

        if ( coords.y < origin.y ) 
            {for (float i = 50; i >= 1; i--)
                if ((coords-origin).magnitude < (left-origin).magnitude/(i))
                {
                    mapposition -= transform.right*50f/(i);
                }
            }

        if ( coords.x > origin.x ) 
            {for (float i = 50; i >= 1; i--)
                if ((coords-origin).magnitude < (top-origin).magnitude/(i))
                {
                    mapposition += transform.forward*50f/(i);
                }
            }

        if ( coords.x < origin.x ) 
            {for (float i = 50; i >= 1; i--)
                if ((coords-origin).magnitude < (bottom-origin).magnitude/(i))
                {
                    mapposition += transform.forward*50f/(i);
                }
            }
    }
        
    }
}
