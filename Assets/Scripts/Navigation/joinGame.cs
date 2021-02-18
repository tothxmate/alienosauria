using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ConnectionNamespace
{
    public class joinGame : MonoBehaviour

    {
        public GameObject roomNr;
        public GameObject name;
        public GameObject popupObject;
        public GameObject popupText;
        public static string roomNumber;
        public static string inGameName;
        public int sceneNr;
        string msg;
        responseMessage res;
        initGuestMessage init_guest;
        // Start is called before the first frame update
        void Start()
        {
            WS.role = "guest";
            WS.ws.OnMessage += (sender, e) =>
            {
                res = JsonUtility.FromJson<responseMessage>(e.Data);
                switch (res.action)
                {
                    case "initGuest":
                        if (res.userid == "none")
                        {
                            Debug.Log("THIS ROOM DOESNT EXIST");
                        }
                        else
                        {
                            Debug.Log("yesyes");
                        }
                        break;
                }
            };
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void BackButton()
        {

            SceneManager.LoadScene(0);
        }


        public void joinAGame()
        {
            
            popup p = new popup();
            roomNumber = roomNr.GetComponent<Text>().text;
            inGameName = name.GetComponent<Text>().text;
            WS.userName = inGameName;
            Debug.Log("Roomnr: "+roomNumber);
            Debug.Log("name"+inGameName);

            if (roomNumber != "" && inGameName != "")
            {
               
            init_guest = new initGuestMessage("initGuest",inGameName,roomNumber);
            WS.ws.Send(JsonUtility.ToJson(init_guest));

            }
            else if (roomNumber != "" && inGameName == "")
            {
                Debug.Log("this shit runs");
                p.popupWindow("Please fill in your name!");
            }

            else if (roomNumber == "" && inGameName != "")
            {
                p.popupWindow("Please fill in the room number!");
            }
            else if (roomNumber == "" && inGameName == ""){
                p.popupWindow("Please fill in the room number and your name!");
            }

            
            /*
            Debug.Log("The room number is: " + roomNumber);

            if (roomNumber != "" && inGameName != "")
            {
                //ide kene a sceneNr-t megkapni a szerotol, h melyik scenere navigaljon
                sceneNr = 3;
                SceneManager.LoadScene(sceneNr);
                userId = 121;
                //inGameName-t + roomNumber-t elkuldeni a szeronak

            }
            else if (roomNumber != "" && inGameName == "")
            {
                Debug.Log("Please fill in your name!");
            }

            else if (roomNumber == "" && inGameName != "")
            {
                Debug.Log("Please fill in the room number!");
            }*/
        }


    }
}