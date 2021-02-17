using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ConnectionNamespace{

public class changeQuestion : MonoBehaviour
{

    Text answer1;
    Text answer2;
    Text answer3;
    Text answer4;
    Text questionText;
    string a;
    string b;
    string c;
    string d;
    string question;
    string answer;
    requestMessage req;
    cardsResponse res;
    // Start is called before the first frame update
    void Start()
    {
        answer1 = GameObject.Find("Canvas/Panel/Answer1/Text").GetComponent<Text>();
        answer2 = GameObject.Find("Canvas/Panel/Answer2/Text").GetComponent<Text>();
        answer3 = GameObject.Find("Canvas/Panel/Answer3/Text").GetComponent<Text>();
        answer4 = GameObject.Find("Canvas/Panel/Answer4/Text").GetComponent<Text>();
        questionText = GameObject.Find("Canvas/Panel/Question").GetComponent<Text>();

        req = new requestMessage(WS.userid_global, "", "generateQuestion");
        WS.ws.Send(JsonUtility.ToJson(req));
        WS.ws.OnMessage += (sender, e) =>
                {
                    res = JsonUtility.FromJson<cardsResponse>(e.Data);
                    switch (res.action)
                    {
                        case "generateQuestion":
                            question = res.question;
                            answer = res.answer;
                            a = res.a;
                            b = res.b;
                            c = res.c;
                            d = res.d;
                            break;
                    }
                };
    }

    // Update is called once per frame
    void Update()
    {
        answer1.text = a;
        answer2.text = b;
        answer3.text = c;
        answer4.text = d;
        questionText.text = question;
    }
}
}