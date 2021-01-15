using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeQuestion : MonoBehaviour
{

    int userId;
    // Start is called before the first frame update
    void Start()
    {
        changeTheQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeTheQuestion() {


        userId = joinGame.userId;
        Debug.Log("user ID is still: " + userId);
        //random questiont be kell huzni es azt berakni a question.text= után
        Text question = GameObject.Find("Canvas/Panel/Question").GetComponent<Text>();
        question.text = "What are the odds of winning this game?";

    }
}
