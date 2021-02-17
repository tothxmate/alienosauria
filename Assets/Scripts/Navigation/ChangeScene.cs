using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int userId = 0;
    public int roomId;

    public void joinGame(string scene_name){
        SceneManager.LoadScene(scene_name);
    }
    public void hostGame() {

        //itt kene valami egyedi szobaszamot generalni a szerveren + tovabbadni a kovi scene-nek
       
        userId = Random.Range(1, 50000);
        roomId = Random.Range(1, 99999);
        Debug.Log("Room id: " + roomId);
        Debug.Log("User id: " + userId);
            
        SceneManager.LoadScene(1);
    }
}
