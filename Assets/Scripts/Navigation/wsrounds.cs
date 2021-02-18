using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConnectionNamespace{
public class wsrounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WS.roundNr++;
        Debug.Log("WSROUND: "+WS.roundNr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
