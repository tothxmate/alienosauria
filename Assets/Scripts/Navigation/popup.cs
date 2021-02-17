using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ConnectionNamespace
{
public class popup : MonoBehaviour
{
    public float countdown = 3;
    public GameObject popupObject;
    public GameObject popupText;
    public static int check;
    public static string globalText;
    
    // Start is called before the first frame update
    void Start()
    {
        popupObject = GameObject.Find("Popup");
        popupText = GameObject.Find("PopupText");
        popupObject.gameObject.GetComponent<Image>().enabled = false;
        popupText.gameObject.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(check == 1 && countdown >= 0){
            countdown -= Time.deltaTime;
            popupObject.gameObject.GetComponent<Image>().enabled = true;
            
           
            popupText.gameObject.GetComponent<Text>().text = globalText;
            popupText.gameObject.GetComponent<Text>().enabled = true;
            Debug.Log("countdown"+countdown);
            return;

        }
        if(countdown < 1){
            popupObject.gameObject.GetComponent<Image>().enabled = false;
            popupText.gameObject.GetComponent<Text>().enabled = false;
            check = 0;
            countdown = 3;
            return;
        }
    }
    public void popupWindow(string text){
       // joinGame j = new joinGame();
        check = 1;
        globalText = text;
        Debug.Log("Anyadat: "+text);
               
    }
}
}