using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootboxSwitcher : MonoBehaviour {

    public Button ShopButton;
    public Button CollButton;
    public Transform Shop;
    public Transform Collection;
    public Camera mainCamera;

    // Use this for initialization
    void Start () {
        ShopButton = GameObject.Find("LeftArrow").GetComponent<Button>();
        CollButton = GameObject.Find("RightArrow").GetComponent<Button>();
        ShopButton.onClick.AddListener(ToShop);
        CollButton.onClick.AddListener(ToCol);


	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToShop()
    {
        Collection.localScale = new Vector3(0, 0, 0);
        Shop.localScale = new Vector3(1, 1, 1);
        mainCamera.transform.localPosition = new Vector3(-113, 15, -27);
    }

    public void ToCol()
    {
        Collection.localScale = new Vector3(1,1,1);
        Shop.localScale = new Vector3(0,0,0);
        mainCamera.transform.localPosition = new Vector3(-93, 15, -27);
    }

}
