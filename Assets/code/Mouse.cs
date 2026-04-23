using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    public int hold = 0;
    public GameObject lime_obj;//1
    public GameObject coconut_obj;//2
    public GameObject soda_obj;//3
    public GameObject watermelon_obj;//4
    public GameObject m250_obj;//5
    public GameObject jelly_obj;//6
    public GameObject water_obj;//7
    public GameObject ice_obj;//8
    public GameObject pineapple_obj;//9
    
    public void Hide()
    {
        lime_obj.SetActive(false);
        coconut_obj.SetActive(false);
        soda_obj.SetActive(false);
        watermelon_obj.SetActive(false);
        m250_obj.SetActive(false);
        jelly_obj.SetActive(false);
        water_obj.SetActive(false);
        ice_obj.SetActive(false);
        pineapple_obj.SetActive(false);
        
    }
    public void Pick(int item)
    {
        hold = item;

    }
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
        if (hold == 0)
        {
            Hide();
        }
        else if (hold == 1)
        {
            lime_obj.SetActive(true);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(false);
            water_obj.SetActive(false);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive (false);



        }
        else if (hold == 2)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(true);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(false);
            water_obj.SetActive(false);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive(false);

        }
        else if (hold == 3)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(true);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(false);
            water_obj.SetActive(false);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive(false);
        }
        else if (hold == 4)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(true);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(false);
            water_obj.SetActive(false);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive(false);

        }
        else if (hold == 5)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(true);
            jelly_obj.SetActive(false);
            water_obj.SetActive(false);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive(false);


        }
        else if (hold == 6)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(true);
            water_obj.SetActive(false);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive(false);

        }
        else if(hold == 7)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(false);
            water_obj.SetActive(true);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive(false);

        }
        else if( hold == 8)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(false);
            water_obj.SetActive(false);
            ice_obj.SetActive(true);
            pineapple_obj.SetActive(false);

        }
        else if( hold == 9)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(false);
            soda_obj.SetActive(false);
            watermelon_obj.SetActive(false);
            m250_obj.SetActive(false);
            jelly_obj.SetActive(false);
            water_obj.SetActive(false);
            ice_obj.SetActive(false);
            pineapple_obj.SetActive(true);
        }
    }
}    