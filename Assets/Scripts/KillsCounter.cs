using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillsCounter : MonoBehaviour
{
    public TextMeshProUGUI title;
    public uint numberOfKills = 0;
    
    void Update()
    {
        title.text = numberOfKills.ToString();
    }
}
