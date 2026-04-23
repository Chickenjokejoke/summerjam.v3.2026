using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mouse : MonoBehaviour
{
    public string ingredientName;
    public Ingredient ingredient;
    public Image icon;

    public override bool Equals(object obj)
    {
        return obj is Mouse mouse &&
               base.Equals(obj) &&
               EqualityComparer<Image>.Default.Equals(icon, mouse.icon);
    }

    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }// Start is called once before the first execution of Update after the MonoBehaviour is created

}
public class Ingredient : MonoBehaviour
{
    
}
