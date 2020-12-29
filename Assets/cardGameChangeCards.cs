using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardGameChangeCards : MonoBehaviour
{
     public Sprite card2;
    // Start is called before the first frame update
    void Start()
    {
    StartCoroutine (Test());
    }    
    

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Test(){
        yield return new WaitForSeconds (2);
        Debug.Log("Wait is over");
        this.gameObject.GetComponent<Image>().sprite = card2;
        Debug.Log("The actual image is:" + this.gameObject.GetComponent<Image>().sprite);
    }

}
