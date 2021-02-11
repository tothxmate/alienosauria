﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFood : MonoBehaviour
{

    public GameObject burger, pizza, pasta, sushi, steak;

    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) {
            whatToSpawn = Random.Range(1, 6);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn) {

                case 1:
                    Vector3 position = new Vector3(Random.Range(-300.0F, 300.0F), Random.Range(0F, 500.0F), 0);
                    GameObject newBurger = Instantiate(burger, position, Quaternion.identity) as GameObject;
                    newBurger.transform.SetParent(GameObject.FindGameObjectWithTag("OverParent").transform,false);
                    break;
                case 2:
                    Vector3 position2 = new Vector3(Random.Range(-300.0F, 300.0F), Random.Range(0F, 500.0F), 0);
                    GameObject newPizza = Instantiate(pizza, position2, Quaternion.identity) as GameObject;
                    newPizza.transform.SetParent(GameObject.FindGameObjectWithTag("OverParent").transform, false);
                    break;
                case 3:
                    Vector3 position3 = new Vector3(Random.Range(-300.0F, 300.0F), Random.Range(0F, 500.0F), 0);
                    GameObject newPasta = Instantiate(pasta, position3, Quaternion.identity) as GameObject;
                    newPasta.transform.SetParent(GameObject.FindGameObjectWithTag("OverParent").transform, false);
                    break;

                case 4:
                    Vector3 position4 = new Vector3(Random.Range(-300.0F, 300.0F), Random.Range(0F, 500.0F), 0);
                    GameObject newSushi = Instantiate(sushi, position4, Quaternion.identity) as GameObject;
                    newSushi.transform.SetParent(GameObject.FindGameObjectWithTag("OverParent").transform, false);
                    break;
                case 5:
                    Vector3 position5 = new Vector3(Random.Range(-300.0F, 300.0F), Random.Range(0F, 500.0F), 0);
                    GameObject newSteak = Instantiate(steak, position5, Quaternion.identity) as GameObject;
                    newSteak.transform.SetParent(GameObject.FindGameObjectWithTag("OverParent").transform, false);
                    break;

            }
            nextSpawn = Time.time + spawnRate;
        }
    }

    /*public void spawnBurger() {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(burger, position, Quaternion.identity);
    }*/ 
}
