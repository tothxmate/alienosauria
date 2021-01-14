using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class joinGame : MonoBehaviour

{

    public GameObject roomNr;
    public GameObject name;
    public string roomNumber;
    public string inGameName;
    public int sceneNr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void joinAGame() {
        roomNumber = roomNr.GetComponent<Text>().text;
        inGameName = name.GetComponent<Text>().text;
        Debug.Log("The room number is: " + roomNumber);

        if (roomNumber != "" && inGameName != "") {
            //ide kene a sceneNr-t megkapni a szerotol, h melyik scenere navigaljon
            sceneNr = 4;
            SceneManager.LoadScene(sceneNr);
            //inGameName-t + roomNumber-t elkuldeni a szeronak

        }
        else {
            Debug.Log("Please fill in both the room number and the name!");
        }
    }
}
