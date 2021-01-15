using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ConnectionNamespace
{
    public class Message : MonoBehaviour
    {
        public string userid;
        public string action;
        public Message(string id, string useraction)
        {
            userid = id;
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