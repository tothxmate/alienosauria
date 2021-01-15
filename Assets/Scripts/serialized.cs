using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConnectionNamespace
{
    [System.Serializable]
    public class serialized : MonoBehaviour
    {

        public static string userId;
        public static string roomNr;

        public static serialized CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<serialized>(jsonString);
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