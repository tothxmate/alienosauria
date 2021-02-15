using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        public static string userid;

        string msg;
        string amount_joined;

        responseMessage res;
        requestMessage req;

        // Start is called before the first frame update
        void Start()
        {
            roomNumber = GameObject.Find("Number");
            inputName = GameObject.Find("NameText");

            basicMessage msg = new basicMessage("initHost");
            WS.ws.Send(JsonUtility.ToJson(msg));
            WS.ws.OnMessage += (sender, e) =>
            {
                res = JsonUtility.FromJson<responseMessage>(e.Data);
                switch (res.action)
                {
                    case "initHost":
                        roomNr = res.response;
                        userid = res.userid;
                        Debug.Log(roomNr);
                        break;
                    case "setPlayerName":
                        if (res.response == "OK")
                        {

                        }
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

        }

        public void BackButton()
        {

            SceneManager.LoadScene(0);
        }

        public void generateRoom()
        {
            //ide kene a sceneNr-t megkapni a szerotol, h melyik scenere navigaljon (vagy akar itt is lehet generalni es a szeronak elkuldeni)
            // + a playersCountot meg kene szerezni
            //playersCount = 4;
            inGameName = inputName.GetComponent<Text>().text;
            Debug.Log(inGameName);

            req = new requestMessage(userid, inGameName, "setPlayerName");
            WS.ws.Send(JsonUtility.ToJson(req));
            /*
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
*/

        }

    }
}