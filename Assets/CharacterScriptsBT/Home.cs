using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
     public void Go(){
        
        SceneManager.LoadScene(0,LoadSceneMode.Single);
        
    }
}
