using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ConnectionNamespace{

public class spawnFood : MonoBehaviour
{

    public GameObject burger, pizza, pasta, sushi, steak;

    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;

    float checkTime = 21;

    requestMessage req;
    // Start is called before the first frame update
    void Start()
    {
        WS.roundNr++;
        Debug.Log("WSROUND: "+WS.roundNr);
    }

    // Update is called once per frame
    void Update()
    {
        checkTime -= Time.deltaTime;
        if (Time.time > nextSpawn && checkTime > 1) {
            
            whatToSpawn = Random.Range(1, 6);
            Debug.Log(whatToSpawn);
            Debug.Log(checkTime);

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

        else if (checkTime <= 0) {
            //count points
            req = new requestMessage(WS.userid_global, ""+WS.foodGamePoints, "addScore");
            WS.ws.Send(JsonUtility.ToJson(req));
             if(WS.roundNr < 3){
                SceneManager.LoadScene(7);
                
            }
            else {
                SceneManager.LoadScene(9);
            }
        }
    }

    /*public void spawnBurger() {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(burger, position, Quaternion.identity);
    }*/ 
}

}