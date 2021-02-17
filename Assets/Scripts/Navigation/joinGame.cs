using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ConnectionNamespace
{
    public class joinGame : MonoBehaviour

    {
        public static int userId;
        public GameObject roomNr;
        public GameObject name;
        public static string roomNumber;
        public static string inGameName;
        public int sceneNr;
        responseMessage res;
        // Start is called before the first frame update
        void Start()
        {
            basicMessage msg = new basicMessage("initGuest");
            WS.ws.Send(JsonUtility.ToJson(msg));
            WS.ws.OnMessage += (sender, e) =>
            {
                res = JsonUtility.FromJson<responseMessage>(e.Data);
                switch (res.action)
                {
                    case "initGuest":
                        if (res.userid == "none")
                        {
                            Debug.Log("nonono");
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

        public void BackButton(){
        
        SceneManager.LoadScene(0);
        }


        public void joinAGame()
        {
            roomNumber = roomNr.GetComponent<Text>().text;
            inGameName = name.GetComponent<Text>().text;
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
            }
        }


    }
}