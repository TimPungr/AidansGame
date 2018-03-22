using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootboxOpener : MonoBehaviour
{

    public GameObject[] objects = new GameObject[48];
    public GameObject[] common = new GameObject[28];
    public GameObject[] uncommon = new GameObject[10];
    public GameObject[] rare = new GameObject[5];
    public GameObject[] legendary = new GameObject[4];
    public GameObject[] epic = new GameObject[1];
    public Button buyButton;
    public int price;
    public Money cash;
    public Camera mainCamera;
    public Transform Shop;
    public Transform Collection;
    public Transform[] showcases = new Transform[6];
    public string thisOne;

    // Use this for initialization
    void Start()
    {
        cash = GameObject.Find("MainLogic").GetComponent<Money>();
        buyButton = GetComponent<Button>();
        buyButton.onClick.AddListener(OpenBox);
        int counter = 0;
        for(int i = 0; i<6; i++)
        {
            int num = i + 1;
            string curr = "Showcase" + num.ToString();
            showcases[i] = GameObject.Find(curr).GetComponent<Transform>();
        }

        foreach (Transform tran in showcases)
        {
            
                tran.localScale = new Vector3(0, 0, 0);
           
        }

        for (int i = 0; i < 48; i++)
        {
            objects[i] = GameObject.Find(i.ToString()).transform.GetChild(0).gameObject;
        }

        for (int i = 0; i<28; i++)
        {
            common[i] = objects[counter];
            counter++;
        }

        for (int i = 0; i < 10; i++)
        {
            uncommon[i] = objects[counter];
            counter++;
        }

        for (int i = 0; i < 5; i++)
        {
            rare[i] = objects[counter];
            counter++;
        }

        for (int i = 0; i < 4; i++)
        {
            legendary[i] = objects[counter];
            counter++;
        }

        for (int i = 0; i < 1; i++)
        {
            epic[i] = objects[counter];
            counter++;
        }



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenBox()
    {
        if (cash.money >= price)
        {
            cash.money -= price;
            mainCamera.transform.localPosition = new Vector3(-100, 15, -34);
            mainCamera.transform.rotation = Quaternion.Euler(10,0,0);
            Shop.localScale = new Vector3(0,0,0);
            foreach (Transform tran in showcases)
            {
                if(tran.name != thisOne)
                {
                    tran.localScale = new Vector3(0,0,0);
                } else
                {
                    tran.localScale = new Vector3(1,1,1);
                }
            }

        }
        else
        {
            System.Random rnd = new System.Random();


        }
    }

}
