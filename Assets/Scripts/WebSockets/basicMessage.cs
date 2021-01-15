using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ConnectionNamespace
{
    public class basicMessage : MonoBehaviour
    {
        
        public string action;
        public basicMessage(string useraction)
        {
            
            action = useraction;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}