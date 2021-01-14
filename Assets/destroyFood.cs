using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyFood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "burger" || collision.gameObject.tag == "pizza" || collision.gameObject.tag == "pasta" || collision.gameObject.tag == "sushi" || collision.gameObject.tag == "steak") {

            Destroy(collision.gameObject);
        
        
        }
    
    }
}
