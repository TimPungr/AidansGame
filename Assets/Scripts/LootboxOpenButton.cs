using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootboxOpenButton : MonoBehaviour {

    public GameObject[] objects = new GameObject[48];
    public GameObject[] common = new GameObject[28];
    public GameObject[] uncommon = new GameObject[10];
    public GameObject[] rare = new GameObject[5];
    public GameObject[] legendary = new GameObject[4];
    public GameObject[] epic = new GameObject[1];
    public int guaranteedCommon;
    public int guaranteedUncommon;
    public int guaranteedRare;
    public int guaranteedLegendary;
    public int guaranteedEpic;


    // Use this for initialization
    void Start () {
        int counter = 0;

        for (int i = 0; i < 48; i++)
        {
            objects[i] = GameObject.Find(i.ToString()).transform.GetChild(0).gameObject;
        }

        for (int i = 0; i < 28; i++)
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
	void Update () {
		
	}
}
