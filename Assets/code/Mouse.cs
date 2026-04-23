using UnityEngine;

public class Mouse : MonoBehaviour
{
    public int hold = 0;
    public GameObject lime_obj;//1
    public GameObject coconut_obj;//2
    public void Hide() 
    {
        lime_obj.SetActive(false);
        coconut_obj.SetActive(false);
    }
    public void Pick(int item)
    {
        hold = item;

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        }
        else if (hold == 2)
        {
            lime_obj.SetActive(false);
            coconut_obj.SetActive(true);
        }

    }
}
