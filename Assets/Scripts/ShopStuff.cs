using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopStuff : MonoBehaviour {

    private float sTimer;
    public float sTime = 0.5f;
    private float mTimer;
    public float mTime = 1f;
    public float sModifier = 1f;
    public float mModifier = 1f;
    public int sAdd = 0;
    public int mAdd = 0;
    public Money moneten;
    public scorer score;
    public tooltips spt;
    public tooltips mpt;
    
    //public Scri

	// Use this for initialization
	void Start () {
        mTimer = mTime;
        sTimer = sTime;
        moneten = GameObject.Find("MainLogic").GetComponent<Money>();
        score = GameObject.Find("MainLogic").GetComponent<scorer>();
        mpt = GameObject.Find("Money").GetComponent<tooltips>();
        spt = GameObject.Find("Score").GetComponent<tooltips>();
    }
	
	// Update is called once per frame
	void Update () {
        mTimer -= Time.deltaTime;
        sTimer -= Time.deltaTime;
        mpt.tooltipText = "Aidans per tick: " + (int)(mAdd * mModifier);
        spt.tooltipText = "Score per tick: " + (int)((sAdd * sModifier) + 1);
        if (mTimer <= 0)
        {
            moneten.money += (int) (mAdd * mModifier);


            mTimer = mTime;
        }
        if (sTimer <= 0)
        {
            score.score += (int)(sAdd * sModifier);


            sTimer = sTime;
        }
    }
}
