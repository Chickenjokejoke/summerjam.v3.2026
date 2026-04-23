using UnityEngine;
using UnityEngine.UI;

public class Smoothy : MonoBehaviour
{
    public Image syrup_img;
    public Sprite syrup_1;
    public Sprite syrup_2;
    public Sprite syrup_3;
    public GameObject syrup_obj;
    public GameObject soda_obj;//3
    public GameObject watermelon_obj;//4
    public GameObject m250_obj;//5
    public GameObject coconut_obj;
    public GameObject lime_obj;
    public GameObject jelly_obj;//6
    public GameObject water_obj;//7
    public GameObject ice_obj;//8
    public GameObject pineapple_obj;//9
    public Mouse mouse;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int syrup = 0;
    public bool have_soda = false;
    public bool have_watermelon = false;
    public bool have_m250 = false;
    public bool have_coconut = false;
    public bool have_lime = false;
    public bool have_jelly = false;
    public bool have_water = false;
    public bool have_ice = false;
    public bool have_pineapple = false;
    void Start()
    {
        
    }
    public void Add() 
    {
        if (mouse.hold == 1)
        {
            have_lime = true;
            mouse.hold = 0;
        }
        else if (mouse.hold == 2)
        {
            have_coconut = true;
            mouse.hold = 0;
        }
        else if (mouse.hold == 3)
        {
            have_soda = true;
            mouse.hold = 0;
        }
        else if (mouse.hold == 4)
        {
            have_watermelon=true;
            mouse.hold = 0;
        }
        else if(mouse.hold == 5)
        {
            have_m250=true;
            mouse.hold=0;
        }
        else if( mouse.hold == 6)
        {
            have_jelly=true;
            mouse.hold = 0;
        }
        else if (mouse.hold == 7)
        {
            have_water = true;
            mouse.hold = 0;
        }
        else if ( mouse.hold == 8)
        {
            have_ice = true;
            mouse.hold = 0;
        }
        else if (mouse.hold == 9)
        {
            have_pineapple=true;
            mouse.hold = 0;
        }
    }
    public void Blend()
    {
             syrup = 0;
      have_soda = false;
      have_watermelon = false;
      have_m250 = false;
      have_coconut = false;
      have_lime = false;
      have_jelly = false;
      have_water = false;
      have_ice = false;
      have_pineapple = false;
}

    // Update is called once per frame
    void Update()
    {
        if (syrup == 0)
        {
            syrup_obj.SetActive(false);
        }
        else 
        {
            syrup_obj.SetActive(true);
            if (syrup == 1)
            {
                syrup_img.sprite = syrup_1;
            }
            else if (syrup == 2) 
            {
                syrup_img.sprite = syrup_2;
            }
            else if (syrup == 3)
            {
                syrup_img.sprite = syrup_3;
            }
        }
        soda_obj.SetActive(have_soda);
        watermelon_obj.SetActive(have_watermelon);
        m250_obj.SetActive(have_m250);
        coconut_obj.SetActive(have_coconut);
        lime_obj.SetActive(have_lime);
        jelly_obj.SetActive(have_jelly);
        water_obj.SetActive(have_water);
        ice_obj.SetActive(have_ice);
        pineapple_obj.SetActive(have_pineapple);
    }
}
