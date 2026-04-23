using System;
using UnityEngine;

public class    gameplay : MonoBehaviour
{
    public Ingredient  Ingredient;
    public  tools Tool;
    public MenuDrinks MenuDrink;  
   public enum MenuDrinks
    {
        StrawberrySmooty, OrangeJuice, PineappleJuice, WatermelonJuice, CoconutJuice, HoneyGreenTea, KivySoda, StrawberrySoda
    }
    public enum ingredients
    {
        soda, water, honey, cha, syrup, strawberry, kivy , orange, Lime, Pineapple , Watermelon, Coconut, Jelly , Jelly1, Jelly2 , Jelly3 , ice
    }
    public enum tools
    {
        tumbler , blender
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
