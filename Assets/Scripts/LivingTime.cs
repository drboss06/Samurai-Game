using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LivingTime : MonoBehaviour
{
    
    public TextMeshProUGUI title;
    public float time = 100.0f;

    void Update()
    {
        time += (Time.deltaTime);
        title.text = Converter(time);
    }
    private string Converter(float seconds)
    {
        string strMinutes;
        string strSeconds;
        int secondsRemainder;
        if (seconds < 3600.0f)
        {
            int minutes = ((int)seconds)/60;

            secondsRemainder = (int)(seconds - minutes * 60);

            if (minutes < 10) strMinutes = $"0{minutes}";            
            else strMinutes = $"{minutes}";
            
            if (secondsRemainder < 10) strSeconds = $"0{(int)(secondsRemainder)}";            
            else strSeconds = $"{(int)(secondsRemainder)}";
            
            return $"{strMinutes}:{strSeconds}";
        }
        else 
        {
            return "Over an hour";
        }
    }
}


