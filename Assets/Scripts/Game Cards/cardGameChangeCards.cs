using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class cardGameChangeCards : MonoBehaviour
{
     public Sprite card1;
     public Sprite card2;
     public Sprite card3;
     public Sprite card4;
     public Sprite card5;
     public Sprite card6;
     public Sprite card7;
     public Sprite card8;
     public Sprite card9;
     public Sprite card10;
     public GameObject cardone;
     public GameObject cardtwo;
     public GameObject cardthree;
     public GameObject cardfour;
     public int randomNumber;
     public static bool btnPressed=true;
     public ArrayList cardStates = new ArrayList();
     public bool checkValue;

    // Start is called before the first frame update
    void Start()
    {    
    if (btnPressed){
    InvokeRepeating("ChangeCards",2,2);
    }
   
    }    
    

    // Update is called once per frame
     void Update(){
        if (btnPressed == false) 
        { 
            CancelInvoke("ChangeCards"); 
        }
       
    }
    
   public void ShowResults()
    {
        btnPressed = false;
         Debug.Log("I canceled the invoke");
         CancelInvoke("ChangeCards");
        cardone = GameObject.Find("Card1");
        cardtwo = GameObject.Find("Card2");
        cardthree = GameObject.Find("Card3");
        cardfour = GameObject.Find("Card4");


        cardStates.Add(cardone.GetComponent<Image>().sprite);
        cardStates.Add(cardtwo.GetComponent<Image>().sprite);
        cardStates.Add(cardthree.GetComponent<Image>().sprite);
        cardStates.Add(cardfour.GetComponent<Image>().sprite);
        foreach (var item in cardStates)
        {
            Debug.Log("The nodes of MDG are:" + item);
        }
        Debug.Log("kartya 1= " + cardStates[0]);
        for (int i = 0; i <= 3; i++)
        {

            if (cardStates[i] == cardStates[i - 1])
            {
                Debug.Log("You won!");
                WonGame();
            }
            else
            {
                Debug.Log("You lost you loser piece of shit!");
                LostGame;
            }
        }
      //  return;

    }

   public void WonGame() {
    
    
   }

   public void LostGame() {
    
   }
    
   void ChangeCards()
   {
    randomNumber = UnityEngine.Random.Range(1,10);
    Debug.Log("The generated random number is: "+randomNumber);
    StartCoroutine (Test());  
   }

      
    IEnumerator Test(){

        switch (randomNumber){

        case 1: 
        this.gameObject.GetComponent<Image>().sprite = card1;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 2: 
        this.gameObject.GetComponent<Image>().sprite = card2;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 3: 
        this.gameObject.GetComponent<Image>().sprite = card3;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 4: 
        this.gameObject.GetComponent<Image>().sprite = card4;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 5: 
        this.gameObject.GetComponent<Image>().sprite = card5;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 6: 
        this.gameObject.GetComponent<Image>().sprite = card6;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 7: 
        this.gameObject.GetComponent<Image>().sprite = card7;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 8: 
        this.gameObject.GetComponent<Image>().sprite = card8;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;

        case 9: 
        this.gameObject.GetComponent<Image>().sprite = card9;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;
        
        case 10: 
        this.gameObject.GetComponent<Image>().sprite = card10;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        break;
        }
    }
        
    

}
