using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ConnectionNamespace{

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
        selectHero h = new selectHero();
        hero = EventSystem.current.currentSelectedGameObject.name;
        h.setSelection();
        
    }
}
}