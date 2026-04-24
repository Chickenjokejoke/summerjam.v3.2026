using System.Collections.Generic;
using UnityEngine;

public class ingredient : MonoBehaviour
{
    public tools Tool;
    public MenuDrinks MenuDrink;
    public recipe Recipe;
    public bool isAdded = false;
    public Sprite Baddrink_img;
    public Sprite kiwi_img;

    // แก้จาก Dictionary ที่ไม่ได้ใช้ → เป็น List ที่เก็บจริง
    private List<recipe> recipes = new List<recipe>();

    public enum MenuDrinks
    {
        WatermelonSmoothie, CoconutSmoothie, M250Smoothie, WatermelonPineappleSmoothie,
        OrangeSmoothie, PineappleSmoothie, HoneyLimeSoda, LimeSoda,
        GreenTeaHoneyLime, GreenTeaHoneyLimeSoda, KiwiSoda, StrawberrySoda,
        KiwiIcedDrink, StrawberryIcedDrink, ChrysanthemumTea, pandantea,
        LonganJuice, IceOrange, OrangeSoda
    }

    public enum ingredients
    {
        soda, water, honey, cha, syrup, strawberry, kiwi, orange, lime,
        pineapple, watermelon, coconut, jelly, ice, pandantea,
        chrysanthemumtea, longanjuice, m250
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
        }
    }

    void Start()
    {
        // blender
        recipes.Add(new recipe(MenuDrinks.WatermelonSmoothie, new ingredients[] { ingredients.watermelon, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender));
        recipes.Add(new recipe(MenuDrinks.CoconutSmoothie, new ingredients[] { ingredients.coconut, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender));
        recipes.Add(new recipe(MenuDrinks.M250Smoothie, new ingredients[] { ingredients.ice, ingredients.m250, ingredients.jelly }, tools.blender));
        recipes.Add(new recipe(MenuDrinks.WatermelonPineappleSmoothie, new ingredients[] { ingredients.watermelon, ingredients.pineapple, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender));
        recipes.Add(new recipe(MenuDrinks.OrangeSmoothie, new ingredients[] { ingredients.orange, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender));
        recipes.Add(new recipe(MenuDrinks.PineappleSmoothie, new ingredients[] { ingredients.pineapple, ingredients.ice, ingredients.syrup, ingredients.water }, tools.blender));

        // tumbler
        recipes.Add(new recipe(MenuDrinks.HoneyLimeSoda, new ingredients[] { ingredients.honey, ingredients.lime, ingredients.soda, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.LimeSoda, new ingredients[] { ingredients.lime, ingredients.soda, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.GreenTeaHoneyLime, new ingredients[] { ingredients.cha, ingredients.honey, ingredients.lime, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.GreenTeaHoneyLimeSoda, new ingredients[] { ingredients.cha, ingredients.honey, ingredients.lime, ingredients.soda, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.KiwiSoda, new ingredients[] { ingredients.kiwi, ingredients.soda, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.StrawberrySoda, new ingredients[] { ingredients.strawberry, ingredients.soda, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.KiwiIcedDrink, new ingredients[] { ingredients.kiwi, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.StrawberryIcedDrink, new ingredients[] { ingredients.strawberry, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.ChrysanthemumTea, new ingredients[] { ingredients.chrysanthemumtea, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.LonganJuice, new ingredients[] { ingredients.longanjuice, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.IceOrange, new ingredients[] { ingredients.orange, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.OrangeSoda, new ingredients[] { ingredients.orange, ingredients.soda, ingredients.ice }, tools.tumbler));
        recipes.Add(new recipe(MenuDrinks.pandantea, new ingredients[] { ingredients.pandantea, ingredients.ice }, tools.tumbler));
    }

    // Smoothy.cs ใช้ดึงสูตรทั้งหมด
    public IReadOnlyList<recipe> GetAllRecipes() => recipes;
}
