using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ConnectionNamespace{
public class results : MonoBehaviour
{
    public GameObject entry;
    public GameObject name;
    public GameObject score;
    requestMessage req;
    responseMessage res;
    public static List<responseMessage> list;
    bool hasListArrived = false;
    int listArrivedCnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        //ide kell requestelni a playercountot (azaz h mennyi player volt a menetben)
        list = new List <responseMessage>();

        req = new requestMessage(WS.userid_global,"","gameReady");
        WS.ws.Send(JsonUtility.ToJson(req));
        WS.ws.OnMessage += (sender, e) =>
        {
            res = JsonUtility.FromJson<responseMessage>(e.Data);
            switch (res.action)
            {
                case "sendAllScores":
                    Debug.Log("sendAllScores");
                    list.Add(new responseMessage(res.userid,res.response,res.action));
                    break;
                case "allScoresSent":
                    hasListArrived = true;
                    break;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        if(hasListArrived==true&&listArrivedCnt==0){
            listArrivedCnt++;
            foreach (var li in list)
            {
                Debug.Log("janijani");
                GameObject newEntry = Instantiate(entry) as GameObject;
                newEntry.transform.SetParent(GameObject.Find("Scores").transform,false);
                GameObject child1 = newEntry.transform.GetChild(0).gameObject;
                GameObject child2 = newEntry.transform.GetChild(1).gameObject;
                child1.GetComponent<Text>().text=li.userid;
                child2.GetComponent<Text>().text=li.response;
                Debug.Log(child1);   
            }
        }
        
    }


}
}