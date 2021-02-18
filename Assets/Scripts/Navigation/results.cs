using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ConnectionNamespace{
public class results : MonoBehaviour
{
    public int playerCount;
    public GameObject entry;
    public GameObject name;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        playerCount=3;//ide kell requestelni a playercountot (azaz h mennyi player volt a menetben)

        for (int i = 1; i<= playerCount; i++){
            GameObject newEntry = Instantiate(entry) as GameObject;
            newEntry.transform.SetParent(GameObject.Find("Scores").transform,false);
            GameObject child1 = newEntry.transform.GetChild(0).gameObject;
            GameObject child2 = newEntry.transform.GetChild(1).gameObject;
            child1.GetComponent<Text>().text="jancsi";
            child2.GetComponent<Text>().text="500";
            child1.GetComponent<Text>().text="eger";
            Debug.Log(child1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }


}
}