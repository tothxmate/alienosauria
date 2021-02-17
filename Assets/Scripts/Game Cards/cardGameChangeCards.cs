using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject wongame;
    public GameObject lostgame;
    public GameObject nextgame;
    public int randomNumber;
    public static bool btnPressed = true;
    public ArrayList cardStates = new ArrayList();
    public bool checkValue;
    public int counter = 0;

    public static int status = 0;
    public int round = 0;
    public float countdown = 3;
    public bool ingame = false;
    public bool lastgame = false;

    requestMessage req;

    // Start is called before the first frame update
    void Start()
    {

        round = 1;
        if (btnPressed)
        {
            InvokeRepeating("ChangeCards", 2, 2);
        }

        wongame = GameObject.Find("GameWon");
        lostgame = GameObject.Find("GameLost");
        nextgame = GameObject.Find("NextGame");
        wongame.gameObject.GetComponent<Image>().enabled = false;
        lostgame.gameObject.GetComponent<Image>().enabled = false;
        nextgame.gameObject.GetComponent<Image>().enabled = false;


    }


    // Update is called once per frame
    void Update()
    {
        if (btnPressed == false)
        {
            CancelInvoke("ChangeCards");
        }

        if (status == 1 && btnPressed == false)
        {
            status = 0;
            Debug.Log("you lost" + status);
            lostgame.gameObject.GetComponent<Image>().enabled = true;
            round++;
            Debug.Log("ROund: " + round);



        }
        else if (status == 2 && btnPressed == false)
        {
            status = 0;
            Debug.Log("you won" + status);
            wongame.gameObject.GetComponent<Image>().enabled = true;
            round++;
            Debug.Log("ROund: " + round);


        }

        if (round < 6 && countdown >= 0 && btnPressed == false)
        {

            countdown -= Time.deltaTime;
            //Debug.Log("countdown" + countdown);
            ingame = true;
        }
        else if (ingame == true)
        {
            ingame = false;
            btnPressed = true;
            wongame.gameObject.GetComponent<Image>().enabled = false;
            lostgame.gameObject.GetComponent<Image>().enabled = false;
            // cardStates.Clear();

            InvokeRepeating("ChangeCards", 0, 2);
            countdown = 3;
            Debug.Log("CUNTDOWN" + countdown);
            if (round == 5)
            {
                lastgame = true;
                CancelInvoke("ChangeCards");
            }

        }

        if (lastgame == true)
        {
            countdown = 5;
            enabled = false;
            CancelInvoke("ChangeCards");
            wongame.gameObject.GetComponent<Image>().enabled = false;
            lostgame.gameObject.GetComponent<Image>().enabled = false;
            // nextgame.gameObject.GetComponent<Image>().enabled = true;
            Debug.Log("countdown= " + countdown);
            countdown -= Time.deltaTime;
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

        for (int i = 0; i <= 3; i++)
        {
            for (int s = 0; s <= 3; s++)
            {

                if (cardStates[i] == cardStates[s])
                {
                    counter++;


                    //Debug.Log("You won!");


                    // wongame = GameObject.Find("GameWon");
                    // wongame.active = true;
                    //Debug.Log("Lefutott");
                    //WonGame();
                }
                else if (cardStates[i] == cardStates[s])
                {

                    Debug.Log("Dont click that yet");

                    counter++;
                    //lostgame = GameObject.Find("GameLost");
                    //lostgame.active = true;
                    //Debug.Log("Lefutott");
                    //LostGame();
                }

            }

            //cardStates.Clear();
        }
        if (counter == 0)
        {

            Debug.Log("you lost");
            counter = 0;
            status = 1;
            cardStates.Clear();

        }
        else if (counter > 0)
        {

            Debug.Log("you won");
            counter = 0;
            status = 2;
            cardStates.Clear();

        }


    }



    void ChangeCards()
    {
        randomNumber = UnityEngine.Random.Range(1, 10);
        Debug.Log("The generated random number is: " + randomNumber);
        StartCoroutine(Test());
    }


    IEnumerator Test()
    {

        switch (randomNumber)
        {

            case 1:
                this.gameObject.GetComponent<Image>().sprite = card1;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                //Debug.Log("Wait is over");
                break;

            case 2:
                this.gameObject.GetComponent<Image>().sprite = card2;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                // Debug.Log("Wait is over");
                break;

            case 3:
                this.gameObject.GetComponent<Image>().sprite = card3;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                // Debug.Log("Wait is over");
                break;

            case 4:
                this.gameObject.GetComponent<Image>().sprite = card4;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                // Debug.Log("Wait is over");
                break;

            case 5:
                this.gameObject.GetComponent<Image>().sprite = card5;
                //  Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                //  Debug.Log("Wait is over");
                break;

            case 6:
                this.gameObject.GetComponent<Image>().sprite = card6;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                // Debug.Log("Wait is over");
                break;

            case 7:
                this.gameObject.GetComponent<Image>().sprite = card7;
                //  Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                // Debug.Log("Wait is over");
                break;

            case 8:
                this.gameObject.GetComponent<Image>().sprite = card8;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                //  Debug.Log("Wait is over");
                break;

            case 9:
                this.gameObject.GetComponent<Image>().sprite = card9;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                // Debug.Log("Wait is over");
                break;

            case 10:
                this.gameObject.GetComponent<Image>().sprite = card10;
                // Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
                yield return new WaitForSeconds(2);
                // Debug.Log("Wait is over");
                break;
        }
    }



}
