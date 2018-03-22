using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSim : MonoBehaviour
{

    public Button buySim;
    public tooltips buttonTooltip;
    public ShopStuff shop;
    public int price = 30;
    public int owned = 0;
    public Money cash;
    string[] notEnoughAidans = new string[] { "Not enough money, sorry ¯_( ͠° ͟ʖ °͠ )_ /¯", "You need more sugar baby @( ◕ x ◕ )@", "╏ ” ⊚ ͟ʖ ⊚ ” ╏" ,"I am running a business here!"};
    public Text ownedText;

    // Use this for initialization
    void Start()
    {
        ownedText = GameObject.Find("SimOwned").GetComponent<Text>();
        buySim = GameObject.Find("SimButton").GetComponent<Button>();
        shop = GameObject.Find("MainLogic").GetComponent<ShopStuff>();
        buySim.onClick.AddListener(Buy);
        buttonTooltip = buySim.GetComponent<tooltips>();
        cash = GameObject.Find("MainLogic").GetComponent<Money>();
        buttonTooltip.tooltipText = "Increases score per tick by 1, Price: " + price;
        ownedText.text = owned + string.Empty;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Buy()
    {
        if (cash.money >= price)
        {
            cash.money -= price;
            price = (int)(price * 1.1f);
            buttonTooltip.tooltipText = "Increases score per tick by 1, Price: " + price;
            shop.sAdd += 1;
            owned++;
            ownedText.text = owned + string.Empty;

        }
        else
        {
            System.Random rnd = new System.Random();
            cash.Third.text = cash.Second.text;
            cash.Second.text = cash.First.text;
            cash.First.text = notEnoughAidans[rnd.Next(notEnoughAidans.Length)];

        }
    }

}
