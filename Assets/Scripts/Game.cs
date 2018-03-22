using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public bool bought = false;
    public string gameName;
    public float cooldown;
    public int sReward;
    public int aReward;
    public int price;
    public Button buyButton;
    public Button useButton;
    public Text cooldownText;
    public Money moneten;
    public scorer Score;
    private float cooldownTimer;
    public Text msg;
    private float delMsg = 5f;

    string[] notEnough = new string[] { "Trying something funny?", "Not enough Money numbnut.", "I am not Santa, got a business to run." };
    string[] toosoon = new string[] { "Wait a second","Not ready yet","Don't play too much","Oi you cheeky numbnut","Come on, wait a bit, will ya" };

    // Use this for initialization
    void Start()
    {
        buyButton = GameObject.Find(gameName + " " + "buy button").GetComponent<Button>();
        useButton = GameObject.Find(gameName + " " + "use button").GetComponent<Button>();
        GameObject.Find(gameName + " " + "use button").GetComponent<tooltips>().tooltipText = "cost: " + price + " Money gain: " + aReward + " Score gain: " + sReward;
        cooldownText = GameObject.Find(gameName + " cooldown").GetComponent<Text>();
        buyButton.onClick.AddListener(Purchase);
        moneten = GameObject.Find("MainLogic").GetComponent<Money>();
        Score = GameObject.Find("MainLogic").GetComponent<scorer>();
        msg = GameObject.Find("FirstLib").GetComponent<Text>();
        cooldownText.text = string.Empty;
        cooldownText.gameObject.SetActive(false);
        cooldownTimer = cooldown;

    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        delMsg -= Time.deltaTime;
        if (delMsg <= 0)
        {

            msg.text = string.Empty;
        }

        if(cooldownTimer <=0)
        {
            cooldownTimer = 0;
        }
        cooldownText.text = (int)cooldownTimer + "s" ;

    }

    public void Purchase()
    {
        if (moneten.money >= price)
        {
            useButton.onClick.AddListener(Play);
            moneten.money -= price;
            GameObject.Destroy(buyButton.gameObject);
            cooldownText.gameObject.SetActive(true);
            bought = true;

        }
        else
        {
            System.Random rnd = new System.Random();
            msg.text = notEnough[rnd.Next(notEnough.Length)];
            delMsg = 5f;
        }
    }

    public void Activate()
    {
        useButton.onClick.AddListener(Play);
        GameObject.Destroy(buyButton.gameObject);
        cooldownText.gameObject.SetActive(true);
    }

    public void Play()
    {
        if(cooldownTimer <= 0)
        {
            Score.score += sReward;
            moneten.money += aReward;

            cooldownTimer = cooldown;
        }
        else
        {
            System.Random rnd = new System.Random();
            msg.text = toosoon[rnd.Next(toosoon.Length)];
            delMsg = 5f;
        }

    }

}
