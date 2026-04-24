using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    public int hold = 0;
    public GameObject lime_obj;       // 1
    public GameObject coconut_obj;    // 2
    public GameObject soda_obj;       // 3
    public GameObject watermelon_obj; // 4
    public GameObject m250_obj;       // 5
    public GameObject jelly_obj;      // 6
    public GameObject water_obj;      // 7
    public GameObject ice_obj;        // 8
    public GameObject pineapple_obj;  // 9
    public GameObject honey_obj;     // 10
    public GameObject syrup_obj;     // 11

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
        honey_obj.SetActive(false);
        syrup_obj.SetActive(false);
    }

    public void Pick(int item)
    {
        hold = item;
    }

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        transform.position = Input.mousePosition;

        // ซ่อนทุกอัน แล้วเปิดแค่อันที่ hold อยู่
        Hide();

        switch (hold)
        {
            case 1: lime_obj.SetActive(true); break;
            case 2: coconut_obj.SetActive(true); break;
            case 3: soda_obj.SetActive(true); break;
            case 4: watermelon_obj.SetActive(true); break;
            case 5: m250_obj.SetActive(true); break;
            case 6: jelly_obj.SetActive(true); break;
            case 7: water_obj.SetActive(true); break;
            case 8: ice_obj.SetActive(true); break;
            case 9: pineapple_obj.SetActive(true); break;
            case 10: honey_obj.SetActive(true); break;
            case 11: syrup_obj.SetActive(true); break;
        }
    }
}
