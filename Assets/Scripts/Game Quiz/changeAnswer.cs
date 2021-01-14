using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeAnswer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //testing
        Text answer1 = GameObject.Find("Canvas/Panel/Answer1/Text").GetComponent<Text>();
        answer1.text = "An answer";
        Text answer2 = GameObject.Find("Canvas/Panel/Answer2/Text").GetComponent<Text>();
        answer2.text = "An other answer";
        Text answer3 = GameObject.Find("Canvas/Panel/Answer3/Text").GetComponent<Text>();
        answer3.text = "Yet an other answer";
        Text answer4 = GameObject.Find("Canvas/Panel/Answer4/Text").GetComponent<Text>();
        answer4.text = "Gtfo bitch";
        //getAnswers();
        //setAnswers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getAnswers() { 
    //todo get list of answers 
    }

    public void setAnswers() {
    //todo set the list of answers to the buttons
    }
}
