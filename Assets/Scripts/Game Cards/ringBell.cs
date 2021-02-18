using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ConnectionNamespace{
public class ringBell : MonoBehaviour
{

    public static bool btnPressed = cardGameChangeCards.btnPressed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RingBell()
   {
    Debug.Log("Button pressed state:"+btnPressed);   
    btnPressed=false;
    Debug.Log("Card one image: "+gameObject.GetComponent<Image>().sprite);
   }
}
}