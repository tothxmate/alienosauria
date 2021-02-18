using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ConnectionNamespace
{
    [Serializable]
    public class responseMessage
    {
        public string userid;
        public string response;
        public string action;
        public responseMessage(string id, string res, string useraction)
        {
            userid = id;
            response = res;
            action = useraction;
        }
    }
}