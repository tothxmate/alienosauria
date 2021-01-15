using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ConnectionNamespace
{
    public class extraMessage : MonoBehaviour
    {
        public string userid;
        public string extra;
        public string action;
        public extraMessage(string id, string useraction, string ex)
        {
            userid = id;
            action = useraction;
            extra = ex;
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