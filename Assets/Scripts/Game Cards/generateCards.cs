using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void generateNumber(){
    //Debug.Log(UnityEngine.Random.Range(0,10));
    List<int> cardList = new List<int>();

    for (int i = 0; i < 10; i++){
        int number = UnityEngine.Random.Range(0,10);
        cardList.Add(number);
    }
    foreach(var number in cardList){
    Debug.Log(number.ToString());
    }
    
}

}
