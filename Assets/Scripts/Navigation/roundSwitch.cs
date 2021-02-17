using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ConnectionNamespace{

public class roundSwitch : MonoBehaviour
{

    public float countdown = 5;
    public int myscore;
    public string converter;
    public GameObject counter;
    public GameObject score;
    int nextScene = 0;
    int updateCount = 0;
    responseMessage res;
    requestMessage req;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Countdown");
        score = GameObject.Find("Score");

        req = new requestMessage(WS.userid_global, "", "getScore");
        WS.ws.Send(JsonUtility.ToJson(req));

        WS.ws.OnMessage += (sender, e) =>
        {
            res = JsonUtility.FromJson<responseMessage>(e.Data);
            switch (res.action)
            {
                case "getScore":
                    myscore = int.Parse(res.response);
                    converter = ""+myscore;
                    score.GetComponent<Text>().text = converter;
                break;
                case "getNextGame":
                    nextScene = int.Parse(res.response);
                break;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0) {
            countdown -= Time.deltaTime;
        }
        if (countdown < 6 && countdown > 4){
            counter.GetComponent<Text>().text = "5";
        }
         if (countdown < 5 && countdown > 3){
            counter.GetComponent<Text>().text = "4";
        }
        if (countdown < 4 && countdown > 2){
            counter.GetComponent<Text>().text = "3";
        }
        if(nextScene!=0){
            SceneManager.LoadScene(nextScene);
        }
    }


}
}