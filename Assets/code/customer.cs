using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class customer : MonoBehaviour
{
    // ============================================================
    // SPRITES
    // ============================================================
    public Sprite c1_1; public Sprite c1_2;
    public Sprite c2_1; public Sprite c2_2;
    public Sprite c3_1; public Sprite c3_2;
    public Sprite c4_1; public Sprite c4_2;
    public Sprite c5_1; public Sprite c5_2;
    public Sprite c6_1; public Sprite c6_2;
    public Sprite c7_1; public Sprite c7_2;
    public Sprite c8_1; public Sprite c8_2;
    public Sprite c9_1; public Sprite c9_2;
    public Sprite c10_1; public Sprite c10_2;
    public Sprite c11_1; public Sprite c11_2;
    public Sprite g1_1; public Sprite g1_2;
    public Sprite g2_1; public Sprite g2_2;
    public Sprite g3_1; public Sprite g3_2;
    public Sprite g4_1; public Sprite g4_2;
    public Sprite g5_1; public Sprite g5_2;

    // ============================================================
    // GAMEOBJECTS
    // ============================================================
    public GameObject c1_obj;  public GameObject c2_obj;
    public GameObject c3_obj;  public GameObject c4_obj;
    public GameObject c5_obj;  public GameObject c6_obj;
    public GameObject c7_obj;  public GameObject c8_obj;
    public GameObject c9_obj;  public GameObject c10_obj;
    public GameObject c11_obj;
    public GameObject g1_obj;  public GameObject g2_obj;
    public GameObject g3_obj;  public GameObject g4_obj;
    public GameObject g5_obj;

    // ============================================================
    // QUEUE & FADE SETTINGS
    // ============================================================
    [Header("Queue Settings")]
    public float showResultTime = 1.5f;
    public float fadeSpeed = 1.5f;

    private int currentIndex = -1;
    private bool currentIsGuest = false;
    private ingredient.MenuDrinks currentOrder;
    private bool isWaiting = false;

    // ============================================================
    // RECIPES
    // ============================================================
    private class RecipeData
    {
        public HashSet<ingredient.ingredients> required;
        public ingredient.tools tool;

        public RecipeData(ingredient.ingredients[] ing, ingredient.tools t)
        {
            required = new HashSet<ingredient.ingredients>(ing);
            tool = t;
        }
    }

    private Dictionary<ingredient.MenuDrinks, RecipeData> recipes
        = new Dictionary<ingredient.MenuDrinks, RecipeData>();

    // ???????????????????????
    private List<ingredient.ingredients> addedIngredients = new List<ingredient.ingredients>();
    private ingredient.tools currentTool;

    // ============================================================
    // START
    // ============================================================
    void Start()
    {
        BuildRecipes();
        SpawnNextCustomer();
    }

    void BuildRecipes()
    {
        recipes[ingredient.MenuDrinks.WatermelonSmoothie]           = new RecipeData(new[] { ingredient.ingredients.watermelon, ingredient.ingredients.ice, ingredient.ingredients.syrup, ingredient.ingredients.water }, ingredient.tools.blender);
        recipes[ingredient.MenuDrinks.CoconutSmoothie]              = new RecipeData(new[] { ingredient.ingredients.coconut, ingredient.ingredients.ice, ingredient.ingredients.syrup, ingredient.ingredients.water }, ingredient.tools.blender);
        recipes[ingredient.MenuDrinks.M250Smoothie]                 = new RecipeData(new[] { ingredient.ingredients.ice, ingredient.ingredients.m250, ingredient.ingredients.jelly }, ingredient.tools.blender);
        recipes[ingredient.MenuDrinks.WatermelonPineappleSmoothie]  = new RecipeData(new[] { ingredient.ingredients.watermelon, ingredient.ingredients.pineapple, ingredient.ingredients.ice, ingredient.ingredients.syrup, ingredient.ingredients.water }, ingredient.tools.blender);
        recipes[ingredient.MenuDrinks.OrangeSmoothie]               = new RecipeData(new[] { ingredient.ingredients.orange, ingredient.ingredients.ice, ingredient.ingredients.syrup, ingredient.ingredients.water }, ingredient.tools.blender);
        recipes[ingredient.MenuDrinks.PineappleSmoothie]            = new RecipeData(new[] { ingredient.ingredients.pineapple, ingredient.ingredients.ice, ingredient.ingredients.syrup, ingredient.ingredients.water }, ingredient.tools.blender);
        recipes[ingredient.MenuDrinks.HoneyLimeSoda]                = new RecipeData(new[] { ingredient.ingredients.honey, ingredient.ingredients.lime, ingredient.ingredients.soda, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.LimeSoda]                     = new RecipeData(new[] { ingredient.ingredients.lime, ingredient.ingredients.soda, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.GreenTeaHoneyLime]            = new RecipeData(new[] { ingredient.ingredients.cha, ingredient.ingredients.honey, ingredient.ingredients.lime, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.GreenTeaHoneyLimeSoda]        = new RecipeData(new[] { ingredient.ingredients.cha, ingredient.ingredients.honey, ingredient.ingredients.lime, ingredient.ingredients.soda, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.KiwiSoda]                     = new RecipeData(new[] { ingredient.ingredients.kiwi, ingredient.ingredients.soda, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.StrawberrySoda]               = new RecipeData(new[] { ingredient.ingredients.strawberry, ingredient.ingredients.soda, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.KiwiIcedDrink]                = new RecipeData(new[] { ingredient.ingredients.kiwi, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.StrawberryIcedDrink]          = new RecipeData(new[] { ingredient.ingredients.strawberry, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.ChrysanthemumTea]             = new RecipeData(new[] { ingredient.ingredients.chrysanthemumtea, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.pandantea]                    = new RecipeData(new[] { ingredient.ingredients.pandantea, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.LonganJuice]                  = new RecipeData(new[] { ingredient.ingredients.longanjuice, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.IceOrange]                    = new RecipeData(new[] { ingredient.ingredients.orange, ingredient.ingredients.ice }, ingredient.tools.tumbler);
        recipes[ingredient.MenuDrinks.OrangeSoda]                   = new RecipeData(new[] { ingredient.ingredients.orange, ingredient.ingredients.soda, ingredient.ingredients.ice }, ingredient.tools.tumbler);
    }

    // ============================================================
    // PLAYER INPUT
    // ============================================================
    public void AddIngredient(ingredient.ingredients ing)
    {
        if (!addedIngredients.Contains(ing))
            addedIngredients.Add(ing);
        else
            Debug.Log($"?? {ing} ????????!");
    }

    public void SetTool(ingredient.tools tool)
    {
        currentTool = tool;
    }

    // ?????????? Serve
    public void OnServe()
    {
        if (isWaiting) return;

        bool isCorrect = CheckRecipe();
        SetCustomerSprite(currentIndex, currentIsGuest, isCorrect);
        addedIngredients.Clear();

        StartCoroutine(ResultThenFade());
    }

    // ============================================================
    // RECIPE CHECK
    // ============================================================
    private bool CheckRecipe()
    {
        if (!recipes.ContainsKey(currentOrder)) return false;

        RecipeData recipe = recipes[currentOrder];
        if (currentTool != recipe.tool) return false;

        HashSet<ingredient.ingredients> playerSet = new HashSet<ingredient.ingredients>(addedIngredients);
        return playerSet.SetEquals(recipe.required);
    }

    // ============================================================
    // CUSTOMER QUEUE
    // ============================================================
    void SpawnNextCustomer()
    {
        int total = Random.Range(0, 16); // 0-10 = customer, 11-15 = guest

        if (total <= 10)
        {
            currentIndex = total;
            currentIsGuest = false;
        }
        else
        {
            currentIndex = total - 11;
            currentIsGuest = true;
        }

        var allMenus = (ingredient.MenuDrinks[])System.Enum.GetValues(typeof(ingredient.MenuDrinks));
        currentOrder = allMenus[Random.Range(0, allMenus.Length)];

        ShowCurrentCustomer();
        Debug.Log($"??????????: {(currentIsGuest ? "g" : "c")}{currentIndex + 1} | ????: {currentOrder}");
    }

    void ShowCurrentCustomer()
    {
        Hide();

        GameObject obj = GetCurrentObject();
        if (obj == null) return;

        obj.SetActive(true);

        SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            Color c = sr.color;
            c.a = 1f;
            sr.color = c;
        }
    }

    IEnumerator ResultThenFade()
    {
        isWaiting = true;
        yield return new WaitForSeconds(showResultTime);
        yield return StartCoroutine(FadeOut());
        SpawnNextCustomer();
        isWaiting = false;
    }

    IEnumerator FadeOut()
    {
        GameObject obj = GetCurrentObject();
        if (obj == null) yield break;

        SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();
        if (sr == null) yield break;

        Color c = sr.color;
        while (c.a > 0f)
        {
            c.a -= Time.deltaTime * fadeSpeed;
            c.a = Mathf.Clamp01(c.a);
            sr.color = c;
            yield return null;
        }
    }

    // ============================================================
    // SPRITE SWAP
    // ============================================================
    void SetCustomerSprite(int index, bool isGuest, bool isCorrect)
    {
        GameObject obj = GetCurrentObject();
        if (obj == null) return;

        SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();
        if (sr == null) return;

        sr.sprite = isCorrect ? GetCorrectSprite(index, isGuest) : GetWrongSprite(index, isGuest);
    }

    Sprite GetCorrectSprite(int index, bool isGuest)
    {
        if (isGuest) switch (index)
        {
            case 0: return g1_1; case 1: return g2_1;
            case 2: return g3_1; case 3: return g4_1;
            case 4: return g5_1;
        }
        else switch (index)
        {
            case 0:  return c1_1;  case 1:  return c2_1;
            case 2:  return c3_1;  case 3:  return c4_1;
            case 4:  return c5_1;  case 5:  return c6_1;
            case 6:  return c7_1;  case 7:  return c8_1;
            case 8:  return c9_1;  case 9:  return c10_1;
            case 10: return c11_1;
        }
        return null;
    }

    Sprite GetWrongSprite(int index, bool isGuest)
    {
        if (isGuest) switch (index)
        {
            case 0: return g1_2; case 1: return g2_2;
            case 2: return g3_2; case 3: return g4_2;
            case 4: return g5_2;
        }
        else switch (index)
        {
            case 0:  return c1_2;  case 1:  return c2_2;
            case 2:  return c3_2;  case 3:  return c4_2;
            case 4:  return c5_2;  case 5:  return c6_2;
            case 6:  return c7_2;  case 7:  return c8_2;
            case 8:  return c9_2;  case 9:  return c10_2;
            case 10: return c11_2;
        }
        return null;
    }

    // ============================================================
    // HELPERS
    // ============================================================
    public void Hide()
    {
        c1_obj.SetActive(false);  c2_obj.SetActive(false);
        c3_obj.SetActive(false);  c4_obj.SetActive(false);
        c5_obj.SetActive(false);  c6_obj.SetActive(false);
        c7_obj.SetActive(false);  c8_obj.SetActive(false);
        c9_obj.SetActive(false);  c10_obj.SetActive(false);
        c11_obj.SetActive(false);
        g1_obj.SetActive(false);  g2_obj.SetActive(false);
        g3_obj.SetActive(false);  g4_obj.SetActive(false);
        g5_obj.SetActive(false);
    }

    GameObject GetCurrentObject()
    {
        if (currentIsGuest) switch (currentIndex)
        {
            case 0: return g1_obj; case 1: return g2_obj;
            case 2: return g3_obj; case 3: return g4_obj;
            case 4: return g5_obj;
        }
        else switch (currentIndex)
        {
            case 0:  return c1_obj;  case 1:  return c2_obj;
            case 2:  return c3_obj;  case 3:  return c4_obj;
            case 4:  return c5_obj;  case 5:  return c6_obj;
            case 6:  return c7_obj;  case 7:  return c8_obj;
            case 8:  return c9_obj;  case 9:  return c10_obj;
            case 10: return c11_obj;
        }
        return null;
    }

    // ??????????????????? (??????? UI ???)
    public ingredient.MenuDrinks GetCurrentOrder() => currentOrder;

    void Update() { }
}