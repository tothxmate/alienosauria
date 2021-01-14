using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadRandomScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadRandomScene() {
        int sceneNr = Random.Range(4, 6);
        SceneManager.LoadScene(sceneNr);
        //itt majd ugye egyseges random numbert kell kapjon az osszes kliens, h ugyanarra a scenere menjenek
    
    }
}
