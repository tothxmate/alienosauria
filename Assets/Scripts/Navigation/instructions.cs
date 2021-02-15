using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class instructions : MonoBehaviour
{
    
   /* public GameObject eatmeout;
    public GameObject cardyb;
    public GameObject quizzy;
    public GameObject comingsoon;*/
    public GameObject description;
    public GameObject descriptionpanel;
    public GameObject back;
    public GameObject bigres;
    public GameObject backtostart;
    public Sprite game1;
    // Start is called before the first frame update
    void Start()
    {
        backtostart = GameObject.Find("BackToStart");
        descriptionpanel = GameObject.Find("DescriptPanel");
        description = GameObject.Find("Description");
        back = GameObject.Find("Back");
        bigres = GameObject.Find("BigRes");
        descriptionpanel.GetComponent<Image>().enabled=false;
        description.GetComponent<Text>().enabled=false;
        back.GetComponent<Image>().enabled=false;
        bigres.GetComponent<Image>().enabled=false;
        backtostart.GetComponent<Image>().enabled=true;
        backtostart.GetComponent<Button>().enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(){
        SceneManager.LoadScene(8);
    }

    public void BackToStart(){
        SceneManager.LoadScene(0);
    }

    public void GameCards(){
       descriptionpanel.GetComponent<Image>().enabled=true;
       back.GetComponent<Image>().enabled=true;
       Text descr1 = GameObject.Find("Description").GetComponent<Text>();
       descr1.text = "There are 4 different cards and a button. When you see 2 identical cards, you should press the button as quickly as you can. Whoever hits the button first, wins points. If you hit the button, but have no identical cards displayed, you lose points.";
       description.GetComponent<Text>().enabled=true;
       bigres.gameObject.GetComponent<Image>().sprite = game1;
       bigres.GetComponent<Image>().enabled=true;
       backtostart.GetComponent<Image>().enabled=false;
       backtostart.GetComponent<Button>().enabled=false;

    }
    public void GameEater(){
       descriptionpanel.GetComponent<Image>().enabled=true;
       back.GetComponent<Image>().enabled=true;
       Text descr2 = GameObject.Find("Description").GetComponent<Text>();
       descr2.text = "You should click on the appearing foods for so long until they disappear. The foods can't reach the line, else you lose points. So be a ninja!";
       description.GetComponent<Text>().enabled=true;
       bigres.gameObject.GetComponent<Image>().sprite = game1;
       bigres.GetComponent<Image>().enabled=true;
       backtostart.GetComponent<Image>().enabled=false;
       backtostart.GetComponent<Button>().enabled=false;


    }
    public void GameQuiz(){
       descriptionpanel.GetComponent<Image>().enabled=true;
       back.GetComponent<Image>().enabled=true;
       Text descr3 = GameObject.Find("Description").GetComponent<Text>();
       descr3.text = "No time pressure this time! Just answer the questions correctly to earn points!";
       description.GetComponent<Text>().enabled=true;
       bigres.gameObject.GetComponent<Image>().sprite = game1;
       bigres.GetComponent<Image>().enabled=true;
       backtostart.GetComponent<Image>().enabled=false;
       backtostart.GetComponent<Button>().enabled=false;

    }

    public void ComingSoon(){
       descriptionpanel.GetComponent<Image>().enabled=true;
       back.GetComponent<Image>().enabled=true;
       Text descr4 = GameObject.Find("Description").GetComponent<Text>();
       descr4.text = "Under construction!";
       description.GetComponent<Text>().enabled=true;
       bigres.gameObject.GetComponent<Image>().sprite = game1;
       bigres.GetComponent<Image>().enabled=true;
       backtostart.GetComponent<Image>().enabled=false;
       backtostart.GetComponent<Button>().enabled=false;

    }

    

}
