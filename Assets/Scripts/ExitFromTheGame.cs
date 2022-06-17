using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFromTheGame : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            GameExitMenu();
        }
    }

    public void GameExitMenu(){
        SceneManager.LoadScene("MenuScene");
    }
}
