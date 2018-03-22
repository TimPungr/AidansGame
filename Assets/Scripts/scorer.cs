using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorer : MonoBehaviour {

    public int score = 0;
    private float timer;
    private float time = 0.5f;
    public Text scoreText;
    public tooltips tips;

	// Use this for initialization
	void Start () {
        timer = time;
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = score + string.Empty;
        tips = GameObject.Find("Score").GetComponent<tooltips>();
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = score + string.Empty;
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            score++;
            timer = time;
        }
		
	}
}
