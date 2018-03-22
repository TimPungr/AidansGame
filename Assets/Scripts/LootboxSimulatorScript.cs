using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootboxSimulatorScript : MonoBehaviour {

    public GameObject[] objects = new GameObject[48];

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 48; i++)
        {
            objects[i] = GameObject.Find(i.ToString());
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
