using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public bool isFullScreen;
    public void PlayPressed(){
        SceneManager.LoadScene("SampleScene");
    }


    public void ExitPressed()
    {
        Application.Quit();
        print("Exit Pressed");
    }

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
}
