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

    public GameObject cha1;
    public GameObject cha2;
    public GameObject cha3;
    public GameObject cha4;
    public GameObject cha5;
    public GameObject cha6;
    public GameObject cha7;
    public GameObject cha8;
    public int save_cha = 0;
    public GameObject water1;
    public GameObject water2;
    public GameObject water3;
    public GameObject water4;
    public int save_water = 0;
   
    public void hide_character()
    {
        cha1.SetActive(false); cha2.SetActive(false);
        cha3.SetActive(false); cha4.SetActive(false);
        cha5.SetActive(false); cha6.SetActive(false);
        cha7.SetActive(false); cha8.SetActive(false);
       
    }
    public void hide_water()
    {
        water1.SetActive(false); water2.SetActive(false);
        water3.SetActive(false); water4.SetActive(false);
    }

    public void save_char(int save_cha)
    {
        this.save_cha = save_cha;
    }
    public void save_wate(int save_water)
    {
        this.save_water = save_water;
    }
    public void lode_char()
    {
        hide_character();

        if (this.save_cha == 0) cha1.SetActive (true);
        if(this.save_cha == 1) cha2.SetActive (true);
        if (this.save_cha == 2) cha3.SetActive (true);
        if( this.save_cha == 3) cha4.SetActive (true);
        if ( this.save_cha == 4) cha5.SetActive (true);
        if (this.save_cha == 5) cha6.SetActive (true);
        if (this .save_cha == 6) cha7.SetActive (true);
        if(this .save_cha == 7) cha8.SetActive (true);
    }
    public void lode_water()
    {
        hide_water();

        if(this.save_water == 0) water1.SetActive (true);
        if(this.save_water == 1) water2.SetActive (true);
        if(this.save_water==2) water3.SetActive (true);
        if(this.save_water == 3) water4.SetActive(true);
    }


    internal static object Menu;


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