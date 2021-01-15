using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectHero : MonoBehaviour
{

    int userId;
    string hero;
    string inGameName;
    string roomNumber;
    int sceneNr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        hero = buttonSelect.hero;
        userId = joinGame.userId;
        inGameName = joinGame.inGameName;
        roomNumber = joinGame.roomNumber;
        //itt kell a sceneNr-t megkapni a szerotol
        sceneNr = 4;
        if (hero != "")
        {
            Debug.Log("Your name is= " + inGameName);
            Debug.Log("Room number is= " + roomNumber);
            Debug.Log("SelectHero user ID is= " + userId);
            Debug.Log("The selected hero is= " + hero);
            SceneManager.LoadScene(sceneNr);
        }
        else {
            Debug.Log("You must choose your Hero first!");
        }
        
        
    }

}
