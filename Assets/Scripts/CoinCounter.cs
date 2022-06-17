using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    
    public TextMeshProUGUI title;
    public uint numberOfCoins = 0;
    void Update()
    {
        title.text = $"{numberOfCoins}/3";
    }
}
