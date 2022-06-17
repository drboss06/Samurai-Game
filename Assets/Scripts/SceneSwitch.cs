using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int sceneIndex;
    public LivingTime timer;

    void OnTriggerEnter2D(Collider2D myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            PlayerPrefs.SetFloat("time", timer.time);
            SceneManager.LoadScene(sceneIndex);
        }
    }
}