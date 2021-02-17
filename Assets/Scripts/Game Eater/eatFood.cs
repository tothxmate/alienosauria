using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatFood : MonoBehaviour
{
    private int randNr;
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // OnCollisionEnter(collision);
    }

    /*void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "burger" || collision.gameObject.tag == "pizza" || collision.gameObject.tag == "pasta" || collision.gameObject.tag == "sushi" || collision.gameObject.tag == "steak") {

            Destroy(collision.gameObject);
            this.gameObject.GetComponent<Button>().enabled = false;
            points++;
            Debug.Log("Poitns"+points);
        
        
        }
    
    }*/

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
    

   


    
    



