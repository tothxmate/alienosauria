using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeQuestion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text question = GameObject.Find ("Canvas/Panel/Question").GetComponent<Text>();
        question.text = "What are the odds of winning this game?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
