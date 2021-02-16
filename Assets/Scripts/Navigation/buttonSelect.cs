using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class buttonSelect : MonoBehaviour
{
    public static string hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonInteract(){

        hero = EventSystem.current.currentSelectedGameObject.name;
        
    }
}
