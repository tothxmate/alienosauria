using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class checkAnswer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkAnswers() {
        Debug.Log("You clicked on the butt"+ EventSystem.current.currentSelectedGameObject.name);
    }
}


