
using WebSocketSharp;
using UnityEngine;

namespace ConnectionNamespace
{
    public static class WS
    {
        public static WebSocket ws;
        public static string userid_global;
        public static int gameNr = 0;
        public static string role;
        public static string userName;
        public static int foodGamePoints = 0;
        public static int cardGamePoints = 0;
        public static int quizGamePoints = 0;
        // Start is called before the first frame update
    }
}