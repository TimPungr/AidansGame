using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switching : MonoBehaviour {

    public Button MainScreenButton;
    public Button GameLibButton;
    public Transform Home;
    public Transform Lib;
    public Camera mainCamera;
    public Button LootBoxButton;
    public Transform LootboxShop;
    public Transform LootboxCollection;

    // Use this for initialization
    void Start () {
        MainScreenButton = GameObject.Find("MainScreenButton").GetComponent<Button>();
        GameLibButton = GameObject.Find("GameLibButton").GetComponent<Button>();
        LootBoxButton = GameObject.Find("LootboxButton").GetComponent<Button>();
        LootBoxButton.onClick.AddListener(ToLootbox);
        MainScreenButton.onClick.AddListener(ToHome);
        GameLibButton.onClick.AddListener(ToLib);
        Home = GameObject.Find("MainScreen").GetComponent<Transform>();
        Lib = GameObject.Find("GameLibrary").GetComponent<Transform>();
        //Lib.SetActive(false);
        Lib.localScale = new Vector3(0,0,0);
        mainCamera.transform.localPosition = new Vector3(0,0,1000);
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ToLib()
    {
        Home.localScale = new Vector3(0, 0, 0);
        Lib.localScale = new Vector3(1, 1, 1);
        mainCamera.transform.localPosition = new Vector3(0, 0, 1000);
        mainCamera.transform.rotation = Quaternion.Euler(10, 0, 0);
    }


    public void ToHome()
    {
        Lib.localScale = new Vector3(0, 0, 0);
        Home.localScale = new Vector3(1, 1, 1);
        mainCamera.transform.localPosition = new Vector3(0, 0, 1000);
        mainCamera.transform.rotation = Quaternion.Euler(10, 0, 0);
    }

    public void ToLootbox()
    {
        Home.localScale = new Vector3(0, 0, 0);
        Lib.localScale = new Vector3(0, 0, 0);
        mainCamera.transform.localPosition = new Vector3(-113, 15, -27);
        LootboxCollection.transform.localScale = new Vector3(0, 0, 0);
        mainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
    }




}
