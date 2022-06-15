using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public bool isFullScreen;
    public void FullScreenCheckBox(){
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    
    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
}
