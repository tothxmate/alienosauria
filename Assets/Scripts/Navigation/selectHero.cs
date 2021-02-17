using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ConnectionNamespace{

public class selectHero : MonoBehaviour
{

    int userId;
    string hero;
    string inGameName;
    string roomNumber;
    int sceneNr;
    bool isHost=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton(){
        if (isHost == true){
        SceneManager.LoadScene(1);
        }
        else if (isHost == false){
        SceneManager.LoadScene(2);
        }
        
        
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
}