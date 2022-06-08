using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChecker : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (settings.active == true){
            mainMenu.SetActive(false);
        }else{
            mainMenu.SetActive(true);
        }
    }
}
