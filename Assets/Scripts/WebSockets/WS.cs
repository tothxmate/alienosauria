
using WebSocketSharp;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ConnectionNamespace
{
    public class WS : MonoBehaviour
    {
       public static WebSocket ws;
        // Start is called before the first frame update
        void Start()
        {
            ws = new WebSocket("ws://134.209.249.13:8080");
            ws.Connect();
          
         
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}