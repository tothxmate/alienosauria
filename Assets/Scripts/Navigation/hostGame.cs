using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using WebSocketSharp;

namespace ConnectionNamespace
{
    public class hostGame : MonoBehaviour
    {
        public GameObject roomNumber;
        public GameObject inputName;
        public GameObject players;
        public string roomNr;
        public int playersCount;
        public string inGameName;
        public static int sceneNr;
        public static string initHostReply;

        string msg;
        string amount_joined = "";

        responseMessage res;
        requestMessage req;

        // Start is called before the first frame update
        void Start()
        {
            WS.role = "host";
            WS.ws = new WebSocket("ws://kutyadoki.hu/socket/");
            WS.ws.Connect();
            players = GameObject.Find("Players");
            roomNumber = GameObject.Find("Number");
            inputName = GameObject.Find("NameText");
            Debug.Log("dasd");
            basicMessage msg = new basicMessage("initHost");
            WS.ws.Send(JsonUtility.ToJson(msg));
            WS.ws.OnMessage += (sender, e) =>
            {
                res = JsonUtility.FromJson<responseMessage>(e.Data);
                switch (res.action)
                {
                    case "initHost":
                        roomNr = res.response;
                        WS.userid_global = res.userid;
                        Debug.Log(roomNr);
                        break;
                    case "getJoinedPlayerAmount":
                        amount_joined = res.response;
                        break;
                }
            };
            while (roomNr == "")
            {
                roomNumber.GetComponent<Text>().text = roomNr;
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            if(amount_joined!=""){
                players.GetComponent<Text>().text = amount_joined+"/4";
            }
        }

        

        public void generateRoom()
        {
            //ide kene a sceneNr-t megkapni a szerotol, h melyik scenere navigaljon (vagy akar itt is lehet generalni es a szeronak elkuldeni)
            // + a playersCountot meg kene szerezni
            //playersCount = 4;
            popup p = new popup();
            inGameName = inputName.GetComponent<Text>().text;
            WS.userName = inGameName;
            Debug.Log(inGameName);
            
            if (inGameName != "")
            {
                req = new requestMessage(WS.userid_global, inGameName, "setPlayerName");
                WS.ws.Send(JsonUtility.ToJson(req));
                sceneNr = 3;
                
                SceneManager.LoadScene(sceneNr);
            }
            else if (inGameName == "")
            {

                Debug.Log("Enter your name!!!!!");
                p.popupWindow("Please fill in your name!");
            }
        }
    }
}