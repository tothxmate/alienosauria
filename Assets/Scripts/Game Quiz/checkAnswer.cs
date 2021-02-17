using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ConnectionNamespace{

public class checkAnswer : MonoBehaviour
{
    public changeQuestion changeQuestion;
    public GameObject text;
    public static int checkValue = 0;
    public static string selectedAnswer;
    public static string selectedText;
    //public joinGame joinGame;
    //public int userId;
    //changeQuestion script = gameObject.GetComponent<changeQuestion>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkAnswers() {
        if (checkValue < 5) {
            //a checkValue az csak egy szam 1-5ig es a roundokat jelenti, es ezt a szerotol kene megkapni
            checkValue++;
            selectedAnswer=EventSystem.current.currentSelectedGameObject.name;
            text = GameObject.Find("Canvas/Panel/"+selectedAnswer+"/Text");
            selectedText = text.GetComponent<Text>().text;
            Debug.Log("text: "+selectedText);
            changeQuestion ch = new changeQuestion();
            ch.checkTheAnswer();
            
            //changeQuestion.changeTheQuestion();
        }
    }
}
}


