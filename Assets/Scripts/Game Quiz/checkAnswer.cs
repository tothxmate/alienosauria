using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class checkAnswer : MonoBehaviour
{
    public changeQuestion changeQuestion;
    public static int checkValue = 0;
    int userId;
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
            Debug.Log("You clicked on the butt" + EventSystem.current.currentSelectedGameObject.name);
            Debug.Log("checkvalue = " + checkValue);
            userId = joinGame.userId;
            Debug.Log("The userID is: " + userId);
            changeQuestion.changeTheQuestion();
            
        }
        //le kene csekkolni h ki milyen answert küldött, es ha a jot kuldte az kap 1 pontot, ha nem, az nem kap
        
    
    }
}


