using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject startMenu, userSelection, characterSelection, typeMenu, map;
    

    // Start is called before the first frame update
    void Start()
    {
        showStartMenu();
    }

    public void showStartMenu()
    {
        print("you clicked");
        startMenu.SetActive(true);
        userSelection.SetActive(false);
        characterSelection.SetActive(false);
        typeMenu.SetActive(false);
        map.SetActive(false);
    }


    public void showUserSkleton()
    {
        print("you clicked showUserSkleton");
        startMenu.SetActive(false);
        userSelection.SetActive(true);
        characterSelection.SetActive(false);
        typeMenu.SetActive(false);
        map.SetActive(false);
    }

    public void showCharacterSelection()
    {
        startMenu.SetActive(false);
        userSelection.SetActive(false);
        characterSelection.SetActive(true);
        typeMenu.SetActive(false);
        map.SetActive(false);
    }

    public void showTypeMenu()
    {
        startMenu.SetActive(false);
        userSelection.SetActive(false);
        characterSelection.SetActive(false);
        typeMenu.SetActive(true);
        map.SetActive(false);
    }

    public void showMap()
    {
        startMenu.SetActive(false);
        userSelection.SetActive(false);
        characterSelection.SetActive(false);
        typeMenu.SetActive(false);
        map.SetActive(true);
    }
}
