using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public bool mute;
    public Image sound;
    public Sprite sound_off;
    public Sprite sound_on;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
    public void mainmenu()
    {
        
    }
    public void exitgame()
    {
        
    }
    public void sound_toggle()
    {
        mute = !mute;
    }
    private void Update()
    {
        if (mute)
        {
            sound.sprite = sound_off;
        }
        else
        {
            sound.sprite = sound_on;
        }
    }
}