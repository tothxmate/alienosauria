using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ConnectionNamespace
{
    //[Serializable]
    public class requestMessage
    {
        public string userid;
        public string value;
        public string action;
        public requestMessage(string id, string val, string useraction)
        {
            userid = id;
            value = val;
            action = useraction;
        }
    }
}