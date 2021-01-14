using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int userId;

    public void joinGame(string scene_name){
        SceneManager.LoadScene(scene_name);
    }
    public void hostGame() {

        //itt kene valami egyedi szobaszamot generalni a szerveren + tovabbadni a kovi scene-nek
        SceneManager.LoadScene(1);
    }
}
