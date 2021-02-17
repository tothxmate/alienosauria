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
    public GameObject guest;
    public GameObject host;
    public string playername1;
    public string playername2;
    public string playername3;
    public string playername4;
    string hero;
    string inGameName;
    string roomNumber;
    int sceneNr;
    
    int selected;
    public ArrayList taken = new ArrayList();
    responseMessage res;
    requestMessage req;
    string roomNr;
    string userName;
    string dinoBlocked;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
        name1 = GameObject.Find("Name1");
        name2 = GameObject.Find("Name2");
        name3 = GameObject.Find("Name3");
        name4 = GameObject.Find("Name4");
         Debug.Log("2");
        dino1 = GameObject.Find("Dino1");
        dino2 = GameObject.Find("Dino2");
        dino3 = GameObject.Find("Dino3");
        dino4 = GameObject.Find("Dino4");
         Debug.Log("3");
        guest = GameObject.Find("Guest");
        guest.gameObject.GetComponent<Image>().enabled = false;
        host = GameObject.Find("Start");
        host.gameObject.GetComponent<Image>().enabled = false;
        Debug.Log("WS ROLE");
        Debug.Log(WS.role);

        if(WS.role=="guest"){
            Debug.Log("guest");
            guest.gameObject.GetComponent<Image>().enabled = true;
        }
        else if (WS.role=="host") {
            Debug.Log("host");
            host.gameObject.GetComponent<Image>().enabled = true;
        }
        Debug.Log("startidk");
        WS.ws.OnMessage += (sender, e) =>
            {   Debug.Log("new message");
                res = JsonUtility.FromJson<responseMessage>(e.Data);
                switch (res.action)
                {
                    case "selectCharacter":
                     Debug.Log("select character");
                        dinoBlocked = res.response;
                        userName = res.userid;
                        taken.Add(dinoBlocked);
                        Debug.Log("Dinoblocked"+dinoBlocked);
                        Debug.Log("Username"+userName);
                        break;
                    case "generateScenes":
                        Debug.Log("NEW MESSAGE BITCHES");
                        Debug.Log(res.response);
                        if(res.response!="ERROR"){
                            startGame(res.response);
                        }else{
                            Debug.Log("wait till everyone chooses character");
                        }
                        break;
                    
                }
                
            };
      //  taken.Add("2");
       // taken.Add("3");
        
        foreach (var item in taken)
        {
            Debug.Log("Taken dinos areee:" + item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
       // setSelection();
        //getSelection();
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
        hero = buttonSelect.hero;
        
        switch(hero){
            case "Dino1":
            selected = 0;
            break;
            case "Dino2":
            selected = 1;
            break;
            case "Dino3":
            selected = 2;
            break;
            case "Dino4":
            selected = 3;
            break;

        }
        Debug.Log("Hero: "+hero);
        Debug.Log("Selected: "+selected);
        requestMessage msg = new requestMessage(WS.userid_global,""+selected,"selectCharacter");
        WS.ws.Send(JsonUtility.ToJson(msg));
        //itt kell elkuldeni a szeronak h melyik dinot valasztottuk
    }

    public void BackButton(){
        if (WS.role == "host"){
        SceneManager.LoadScene(1);
        }
        else if (WS.role == "guest"){
        SceneManager.LoadScene(2);
        }
        
        
    }
    
        
    

    public void areCharactersSelected() {
        hero = buttonSelect.hero;
        popup p = new popup();
        if (hero!=null){
            Debug.Log("if mukodott"+hero+"asdf");
            requestMessage msg = new requestMessage(WS.userid_global,"","generateScenes");
            WS.ws.Send(JsonUtility.ToJson(msg));
        }
        else{
            p.popupWindow("Select a hero!");
        }    
        

    }

    public void startGame(string gameNr){
        Debug.Log("startgame");
        //SceneManager.LoadScene(int.Parse(gameNr));
        SceneManager.LoadScene(0);
        Debug.Log("startgame");
    }

}
}