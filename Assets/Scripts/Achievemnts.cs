using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievemnts : MonoBehaviour
{

    public Image start;
    public Image ten;
    public Image hundred;
    public scorer score;
    public Text achText;
    public bool first = false;
    public bool second = false;
    public bool third = false;
    private Color fu;
    private Color gone;
    public float stayTime = 5f;
    public float stayTimer;

    // Use this for initialization
    void Start()
    {
        score = GameObject.Find("MainLogic").GetComponent<scorer>();
        start = GameObject.Find("AchievementImageStart").GetComponent<Image>();
        ten = GameObject.Find("AchievementImage10").GetComponent<Image>();
        hundred = GameObject.Find("AchievementImage100").GetComponent<Image>();
        achText = GameObject.Find("Achievement Text").GetComponent<Text>();
        fu = start.color;
        fu.a = 255;
        gone = start.color;
    }

    // Update is called once per frame
    void Update()
    {
        stayTimer -= Time.deltaTime;

        if (score.score > 0 && first == false)
        {
            achText.text = "Achievement unlocked! \n Started the game!";
           start.color = fu;
            first = true;
            stayTimer = stayTime;
        }
        if (score.score > 9 && second == false)
        {
            achText.text = "Achievement unlocked! \n Got 10 score!";
            ten.color = fu;
            start.color = gone;
            second = true;
            stayTimer = stayTime;
        }
        if (score.score > 99 && third == false)
        {
            achText.text = "Achievement unlocked! \n Got 100 score!";
            hundred.color = fu;
            ten.color = gone;
            third = true;
            stayTimer = stayTime;
        }

        if (stayTimer <= 0)
        {
            achText.text = string.Empty;
            start.color = gone;
            ten.color = gone;
            hundred.color = gone;
        }


    }


}
