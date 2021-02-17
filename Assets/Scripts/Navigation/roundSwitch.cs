using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ConnectionNamespace{

public class roundSwitch : MonoBehaviour
{

    public float countdown = 6;
    public string myscore = null;
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
                    myscore = res.response;
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
        if(myscore!=null){
            score.GetComponent<Text>().text = myscore;
        }
        if (countdown > 0) {
            countdown -= Time.deltaTime;
        }
        counter.GetComponent<Text>().text = ((int)countdown).ToString();
        if(countdown<=0&&updateCount==0){
            updateCount++;
            Debug.Log("benne vok tesom");
            req = new requestMessage(WS.userid_global, "", "getNextGame");
            WS.ws.Send(JsonUtility.ToJson(req));
        }
        if(nextScene!=0){
            SceneManager.LoadScene(nextScene);
        }
    }
}
}