using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ConnectionNamespace{

public class changeQuestion : MonoBehaviour
{

    Text answer1;
    Text answer2;
    Text answer3;
    Text answer4;
    Text questionText;
    GameObject button1;
    GameObject button2;
    GameObject button3;
    GameObject button4;
    public GameObject counter;
    public GameObject changeColor;
    public string selectedAnswer;
    public string a;
    public string b;
    public string c;
    public string d;
    public string question;
    public static string answer;
    public static int rounds;
    public static int sceneNr;
    public static float countdown=4;
    public static float colorCounter=2;
    requestMessage req;
    cardsResponse res;

    string selectedText;
    // Start is called before the first frame update
    void Start()
    {  
        counter = GameObject.Find("Countdown");
        WS.roundNr++;
        answer1 = GameObject.Find("Canvas/Panel/Answer1/Text").GetComponent<Text>();
        answer2 = GameObject.Find("Canvas/Panel/Answer2/Text").GetComponent<Text>();
        answer3 = GameObject.Find("Canvas/Panel/Answer3/Text").GetComponent<Text>();
        answer4 = GameObject.Find("Canvas/Panel/Answer4/Text").GetComponent<Text>();
        button1 = GameObject.Find("Answer1");
        button2 = GameObject.Find("Answer2");
        button3 = GameObject.Find("Answer3");
        button4 = GameObject.Find("Answer4");
        questionText = GameObject.Find("Canvas/Panel/Question").GetComponent<Text>();
        answer1.enabled = false;
        answer2.enabled = false;
        answer3.enabled = false;
        answer4.enabled = false;
        button1.GetComponent<Button>().enabled = false;
        button2.GetComponent<Button>().enabled = false;
        button3.GetComponent<Button>().enabled = false;
        button4.GetComponent<Button>().enabled = false;

      /*  req = new requestMessage(WS.userid_global, "", "generateQuestion");
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
                };*/
                a = "jancsi";
                b = "marcsi";
                c = "pisti";
                d = "bendzsi";
                question = "Ki a legszebb?";
                answer = "jancsi";

    }

    // Update is called once per frame
    void Update()
    {  
         countdown -= Time.deltaTime;
         

        if(countdown > 1 && rounds <= 6){
            colorCounter -= Time.deltaTime;
       counter.GetComponent<Text>().text = ((int)countdown).ToString();
       if(colorCounter > 1){
            Debug.Log("Colored as hell!");
        
        }
        else if(colorCounter < 1) {
        button1.GetComponent<Image>().color = new Color32(255,255,255,255);
        button2.GetComponent<Image>().color = new Color32(255,255,255,255);
        button3.GetComponent<Image>().color = new Color32(255,255,255,255);
        button4.GetComponent<Image>().color = new Color32(255,255,255,255);
        colorCounter = 2;
        }
        
    }
     if (countdown < 1 && rounds <= 6) {
        
        Debug.Log("Colrocounter"+colorCounter);
        button1.GetComponent<Button>().enabled = true;
        button2.GetComponent<Button>().enabled = true;
        button3.GetComponent<Button>().enabled = true;
        button4.GetComponent<Button>().enabled = true;
        answer1.enabled = true;
        answer2.enabled = true;
        answer3.enabled = true;
        answer4.enabled = true;
        answer1.text = a;
        answer2.text = b;
        answer3.text = c;
        answer4.text = d;
        questionText.text = question;
        rounds++;
        countdown = 11;
        
    }
        
        if (rounds == 6){
             if(WS.roundNr < 3){
                SceneManager.LoadScene(7);
                
            }
            else {
                SceneManager.LoadScene(9);
            }
        }
    }

    public void checkTheAnswer(){     
        selectedText = checkAnswer.selectedText;
        selectedAnswer = checkAnswer.selectedAnswer;
        changeColor = GameObject.Find("Canvas/Panel/"+selectedAnswer);
        Debug.Log("selectedText: "+selectedText);
        Debug.Log("answer: "+answer);
            if(selectedText==answer && rounds <= 6){    
                WS.quizGamePoints++;
                changeColor.gameObject.GetComponent<Image>().color = new Color32(13,236,65,255);
                countdown = 0;
                Debug.Log("Right answer!"+WS.quizGamePoints);
                Debug.Log("Rounds: "+rounds);
                //ide kell még requestelni uj kérdéseket és válaszokat
            }
            else {
                changeColor.gameObject.GetComponent<Image>().color = new Color32(243,0,0,255);
                countdown = 0;
                Debug.Log("Rounds: "+rounds);
                Debug.Log("Youre quite stupid! :(");
            }
    }

    
}
}