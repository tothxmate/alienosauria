using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class results : MonoBehaviour
{
    public int playerCount;
    public GameObject entry;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 1; i<= playerCount; i++){
            GameObject newEntry = Instantiate(entry) as GameObject;
            newEntry.transform.SetParent(GameObject.Find("Scores").transform,false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
