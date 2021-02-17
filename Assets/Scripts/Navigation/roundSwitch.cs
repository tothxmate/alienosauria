using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class roundSwitch : MonoBehaviour
{

    public float countdown = 6;
    public int myscore;
    public string converter;
    public GameObject counter;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Countdown");
        score = GameObject.Find("Score");
        myscore = 200;
        converter = ""+myscore;
        Debug.Log("Converter = "+myscore);
        score.GetComponent<Text>().text = converter;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0) {
            countdown -= Time.deltaTime;
        }
        if (countdown < 4 && countdown > 2){
            counter.GetComponent<Text>().text = "3";
        }
        if (countdown < 3 && countdown > 1){
            counter.GetComponent<Text>().text = "2";
        }
        if (countdown < 2 && countdown > 0){
            counter.GetComponent<Text>().text = "1";
        }
        if (countdown < 1 && countdown > -1){
            counter.GetComponent<Text>().text = "GO!";
            SceneManager.LoadScene(4);


        }
    }


}
