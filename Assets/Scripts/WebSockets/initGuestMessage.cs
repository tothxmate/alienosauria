using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ConnectionNamespace
{
    [Serializable]
    public class initGuestMessage
    {
        string action;
        string username;
        string roomNumber;
        public initGuestMessage(string a, string u, string rn)
        {
            action = a;
            username = u;
            roomNumber = rn;
        }
    }
}