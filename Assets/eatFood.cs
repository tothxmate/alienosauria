using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatFood : MonoBehaviour
{
    private int randNr;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void eatTheFood()
    {
    randNr = Random.Range(0, 7);
        Debug.Log("The randum number is=" + randNr);
        if (randNr == 1)
        {
            Debug.Log("I should have been destroyed");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Eat me more");
        }



    }
}
    

   


    
    



