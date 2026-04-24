using System;
using System.Collections.Generic;
using UnityEngine;

public class ingredient : MonoBehaviour
{
    //public Ingredient  Ingredient;
    public tools Tool;   
   
    public MenuDrinks MenuDrink;
    public recipe Recipe;
    public bool isAdded = false;
    public Sprite Baddrink_img;
    public Sprite kiwi_img;


    Dictionary<MenuDrinks, recipe> recipes = new Dictionary<MenuDrinks, recipe>();

    public enum MenuDrinks
    {
        
        WatermelonSmoothie, CoconutSmoothie, M250Smoothie, WatermelonPineappleSmoothie, OrangeSmoothie, PineappleSmoothie, HoneyLimeSoda, LimeSoda,
        GreenTeaHoneyLime, GreenTeaHoneyLimeSoda, KiwiSoda, StrawberrySoda, KiwiIcedDrink, StrawberryIcedDrink, ChrysanthemumTea, pandantea, LonganJuice, IceOrange, OrangeSoda
    }
    public enum getcomponent ingredients
    {
       
        soda, water, honey, cha, syrup, strawberry, kiwi, orange, Lime, Pineapple, Watermelon, Coconut, Jelly,  ice, pandantea, chrysanthemumtea, longanjuice, m250
    }
    public enum tools
    {
        tumbler, blender
    }

    public class recipe
    {
        public MenuDrinks menuDrink;
        public ingredients[] ingredients;
        public tools tool;

        public recipe(MenuDrinks menuDrink, ingredients[] ingredients, tools tool)
        {
            this.menuDrink = menuDrink;
            this.ingredients = ingredients;
            this.tool = tool;
            // กำหนดค่าเริ่มต้นเป็น tumbler
        }

        public recipe(MenuDrinks watermelonSmoothie, ingredients[] ingredients, tools blender, tools tumbler)
        {
            this.ingredients = ingredients;
        }






    }

    void Start()
    {

        new recipe(MenuDrinks.WatermelonSmoothie, new ingredients[] { ingredients.Watermelon, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender, tools.tumbler);
        new recipe(MenuDrinks.CoconutSmoothie, new ingredients[] { ingredients.Coconut, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender, tools.tumbler);
        new recipe(MenuDrinks.M250Smoothie, new ingredients[] { ingredients.ice, ingredients.m250, ingredients.Jelly }, tools.blender, tools.tumbler);
        new recipe(MenuDrinks.WatermelonPineappleSmoothie, new ingredients[] { ingredients.Watermelon, ingredients.Pineapple, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender, tools.tumbler);
        new recipe(MenuDrinks.OrangeSmoothie, new ingredients[] { ingredients.orange, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender, tools.tumbler);
        new recipe(MenuDrinks.PineappleSmoothie, new ingredients[] { ingredients.Pineapple, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender, tools.tumbler);
        new recipe(MenuDrinks.HoneyLimeSoda, new ingredients[] { ingredients.honey, ingredients.Lime, ingredients.soda, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.LimeSoda, new ingredients[] { ingredients.Lime, ingredients.soda, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.GreenTeaHoneyLime, new ingredients[] { ingredients.cha, ingredients.honey, ingredients.Lime, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.GreenTeaHoneyLimeSoda, new ingredients[] { ingredients.cha, ingredients.honey, ingredients.Lime, ingredients.soda, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.KiwiSoda, new ingredients[] { ingredients.kiwi, ingredients.soda, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.StrawberrySoda, new ingredients[] { ingredients.strawberry, ingredients.soda, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.KiwiIcedDrink, new ingredients[] { ingredients.kiwi, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.StrawberryIcedDrink, new ingredients[] { ingredients.strawberry, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.ChrysanthemumTea, new ingredients[] { ingredients.chrysanthemumtea, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.LonganJuice, new ingredients[] { ingredients.longanjuice, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.IceOrange, new ingredients[] { ingredients.orange, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.OrangeSoda, new ingredients[] { ingredients.orange, ingredients.soda, ingredients.ice }, tools.tumbler);
        new recipe(MenuDrinks.pandantea, new ingredients[] { ingredients.pandantea, ingredients.ice }, tools.tumbler);

    }




    // Update is called once per frame
    void Update()
    {

    }

}
