
using WebSocketSharp;
using UnityEngine;

namespace ConnectionNamespace
{
    public class WS : MonoBehaviour
    {
        public static WebSocket ws;
        // Start is called before the first frame update
        void Start()
        {
            ws = new WebSocket("ws://kutyadoki.hu/socket/");
            ws.Connect();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}