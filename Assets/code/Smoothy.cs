using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smoothy : MonoBehaviour
{
    [Header("Tool ของเครื่องนี้")]
    public ingredient.tools myTool;

    [Header("References")]
    public ingredient ingredientManager;
    public Mouse mouse;

    [Header("Syrup")]
    public GameObject honey_obj;
    public GameObject syrup_obj;

    [Header("Ingredient Objects")]
    public GameObject soda_obj;
    public GameObject watermelon_obj;
    public GameObject m250_obj;
    public GameObject coconut_obj;
    public GameObject lime_obj;
    public GameObject jelly_obj;
    public GameObject water_obj;
    public GameObject ice_obj;
    public GameObject pineapple_obj;

    [Header("Result Objects")]
    public GameObject WatermelonSmoothie_obj;
    // public GameObject CoconutSmoothie_obj;

    // ประกาศครบทุกตัว
    public bool have_soda = false;
    public bool have_watermelon = false;
    public bool have_m250 = false;
    public bool have_coconut = false;
    public bool have_lime = false;
    public bool have_jelly = false;
    public bool have_water = false;
    public bool have_ice = false;
    public bool have_pineapple = false;
    public bool have_honey = false; // เพิ่มแล้ว
    public bool have_syrup = false; // เพิ่มแล้ว
    public bool have_watermelon_smoothie = false;

    void Start() { }

    public void Add()
    {
        switch (mouse.hold)
        {
            case 1: have_lime = true; break;
            case 2: have_coconut = true; break;
            case 3: have_soda = true; break;
            case 4: have_watermelon = true; break;
            case 5: have_m250 = true; break;
            case 6: have_jelly = true; break;
            case 7: have_water = true; break;
            case 8: have_ice = true; break;
            case 9: have_pineapple = true; break;
            case 10: have_honey = true; break;
            case 11: have_syrup = true; break; // แก้จาก syrup = true
        }
        mouse.hold = 0;
        mouse.Hide();
    }

    public void Blend()
    {
        var current = new HashSet<ingredient.ingredients>();
        if (have_soda) current.Add(ingredient.ingredients.soda);
        if (have_watermelon) current.Add(ingredient.ingredients.watermelon);
        if (have_m250) current.Add(ingredient.ingredients.m250);
        if (have_coconut) current.Add(ingredient.ingredients.coconut);
        if (have_lime) current.Add(ingredient.ingredients.lime);
        if (have_jelly) current.Add(ingredient.ingredients.jelly);
        if (have_water) current.Add(ingredient.ingredients.water);
        if (have_ice) current.Add(ingredient.ingredients.ice);
        if (have_pineapple) current.Add(ingredient.ingredients.pineapple);
        if (have_honey) current.Add(ingredient.ingredients.honey);
        if (have_syrup) current.Add(ingredient.ingredients.syrup);

        ingredient.recipe matched = null;
        foreach (var r in ingredientManager.GetAllRecipes())
        {
            if (new HashSet<ingredient.ingredients>(r.ingredients).SetEquals(current))
            {
                matched = r;
                break;
            }
        }

        if (matched == null)
        {
            Debug.Log("ไม่มีสูตรนี้!");
            ClearIngredients();
            return;
        }

        if (matched.tool != myTool)
        {
            Debug.Log($"ต้องใช้ {matched.tool} ไม่ใช่ {myTool}!");
            ClearIngredients();
            return;
        }

        Debug.Log($"ได้เมนู: {matched.menuDrink}!");
        ShowResult(matched.menuDrink);
        ClearIngredients();
    }

    private void ShowResult(ingredient.MenuDrinks drink)
    {
        switch (drink)
        {
            case ingredient.MenuDrinks.WatermelonSmoothie:
                if (WatermelonSmoothie_obj) WatermelonSmoothie_obj.SetActive(true);
                break;
            default:
                Debug.Log($"{drink} ยังไม่มี result object");
                break;
        }
    }

    private void ClearIngredients()
    {
        have_soda = have_watermelon = have_m250 = have_coconut = false;
        have_lime = have_jelly = have_water = have_ice = have_pineapple = false;
        have_honey = have_syrup = false;
    }

    void Update()
    {
        honey_obj.SetActive(have_honey);
        syrup_obj.SetActive(have_syrup);
        soda_obj.SetActive(have_soda);
        watermelon_obj.SetActive(have_watermelon);
        m250_obj.SetActive(have_m250);
        coconut_obj.SetActive(have_coconut);
        lime_obj.SetActive(have_lime);
        jelly_obj.SetActive(have_jelly);
        water_obj.SetActive(have_water);
        ice_obj.SetActive(have_ice);
        pineapple_obj.SetActive(have_pineapple);
        WatermelonSmoothie_obj.SetActive(have_watermelon_smoothie);
    }
}
