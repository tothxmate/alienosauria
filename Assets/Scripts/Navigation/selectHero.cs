using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ConnectionNamespace{

public class selectHero : MonoBehaviour
{

    public GameObject name1;
    public GameObject name2;
    public GameObject name3;
    public GameObject name4;
    public GameObject dino1;
    public GameObject dino2;
    public GameObject dino3;
    public GameObject dino4;
    public string playername1;
    public string playername2;
    public string playername3;
    public string playername4;
    int userId;
    string hero;
    string inGameName;
    string roomNumber;
    int sceneNr;
    bool isHost=true;
    int selected;
    public ArrayList taken = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        taken.Add("2");
        taken.Add("3");
        name1 = GameObject.Find("Name1");
        name2 = GameObject.Find("Name2");
        name3 = GameObject.Find("Name3");
        name4 = GameObject.Find("Name4");
        dino1 = GameObject.Find("Dino1");
        dino2 = GameObject.Find("Dino2");
        dino3 = GameObject.Find("Dino3");
        dino4 = GameObject.Find("Dino4");
    }

    // Update is called once per frame
    void Update()
    {
        
        hero = buttonSelect.hero;
        setSelection();
        getSelection();
        playername1 = "Janos";
        playername2 = "Bela";
        playername3 = "Kalman";
        playername4 = "Istvan";
        name1.GetComponent<Text>().text = ""+playername1;
        name2.GetComponent<Text>().text = ""+playername2;
        name3.GetComponent<Text>().text = ""+playername3;
        name4.GetComponent<Text>().text = ""+playername4;
        
    }
    //gets the selected heros of opponents
    public void getSelection(){
            
            for (int i = 0; i<=3;i++){
                
                if(taken[i]=="1"){
                    dino1.GetComponent<Button>().enabled = false;
                }
                else if(taken[i]!="1"){
                    dino1.GetComponent<Button>().enabled = true;
                }
                if(taken[i]=="2"){
                    dino2.GetComponent<Button>().enabled = false;
                }
                else if(taken[i]!="2"){
                    dino2.GetComponent<Button>().enabled = true;
                }
                if(taken[i]=="3"){
                    dino3.GetComponent<Button>().enabled = false;
                }
                else if(taken[i]!="3"){
                    dino3.GetComponent<Button>().enabled = true;
                }
                if(taken[i]=="4"){
                    dino4.GetComponent<Button>().enabled = false;
                }
                else if(taken[i]!="4"){
                    dino4.GetComponent<Button>().enabled = true;
                }
                
                return;

            }
        

    }

    public void setSelection(){
        
        switch(hero){
            case "Dino1":
            selected = 1;
            break;
            case "Dino2":
            selected = 2;
            break;
            case "Dino3":
            selected = 3;
            break;
            case "Dino4":
            selected = 4;
            break;

        }
        Debug.Log("Hero: "+hero);
        Debug.Log("Selected: "+selected);
        //itt kell elkuldeni a szeronak h melyik dinot valasztottuk
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
        Debug.Log("Worked");
        taken.Add("4");
        taken.Remove("2");
        Debug.Log("Workedsss");
        dino2.GetComponent<Button>().enabled = true;
        foreach (var item in taken)
        {
            Debug.Log("Taken dinos are:" + item);
        }

       /* hero = buttonSelect.hero;
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
        */
        
    }

}
}