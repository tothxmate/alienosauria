using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class results : MonoBehaviour
{
    public GameObject entry;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newEntry = Instantiate(entry) as GameObject;
        newEntry.transform.SetParent(GameObject.Find("Scores").transform,false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
