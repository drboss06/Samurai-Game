using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSoundPlayer : MonoBehaviour
{
    public AudioSource audioMenu;
    public AudioClip[] menuClips;
    void Start()
    {
        audioMenu = GetComponent<AudioSource>();
    }
    void PlayRandomClipMenu(){
        if(audioMenu.isPlaying) return;
        audioMenu.clip = menuClips[Random.Range(0, menuClips.Length - 1)];
        audioMenu.Play();
    }
    void Update()
    {
        PlayRandomClipMenu();
    }
}
