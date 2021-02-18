using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ConnectionNamespace
{
    public class basicMessage
    {
        public string action;
        public basicMessage(string useraction)
        {

            action = useraction;
        }
    }
}