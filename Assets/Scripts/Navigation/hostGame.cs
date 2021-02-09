using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using SimpleJSON;



namespace ConnectionNamespace
{
    public class hostGame : MonoBehaviour
    {
        public GameObject roomNumber;
        public GameObject name;
        public GameObject players;
        public string roomNr;
        public int playersCount;
        public string inGameName;
        public static int sceneNr;
        public static string initHostReply;

        // Start is called before the first frame update
        void Start()
        {
            
            basicMessage msg = new basicMessage("initHost");
            WS.ws.Send(JsonUtility.ToJson(msg));
            WS.ws.OnMessage += (sender, e) =>
            {
                initHostReply=e.Data;
            };
           // serialized.CreateFromJSON(initHostReply);
            roomNr = serialized.roomNr;
            Debug.Log(roomNr);

            roomNumber.GetComponent<Text>().text = roomNr;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void generateRoom()
        {
            //ide kene a sceneNr-t megkapni a szerotol, h melyik scenere navigaljon (vagy akar itt is lehet generalni es a szeronak elkuldeni)
            // + a playersCountot meg kene szerezni
            playersCount = 4;
            inGameName = name.GetComponent<Text>().text;
            if (playersCount == 4 && inGameName != "")
            {
                //inGameName-t elkuldeni a szeronak
                sceneNr = 4;
                Debug.Log("Game has started successfully");
                SceneManager.LoadScene(sceneNr);
            }
            else
            {
                Debug.Log("Wait for the players to join and enter your name!");

            }



        }

    }
}