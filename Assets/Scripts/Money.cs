using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    public int money = 0;
    public Text moneyText;
    public Button autismos;
    public Text First;
    public Text Second;
    public Text Third;

    string[] Phrases = new string[] {"Aidan gained","More autism appears","Even more autism","Thanks for clicking","This is retarded", "You click me just right","Oh yeah, love your clicking","this is autistic","You really want to see that number increase, huh?", "love you", "Ho ho ho, merry FUCK YOU!", "We wish you a merry fuckmas" };

    // Use this for initialization
    void Start () {
        autismos = GameObject.Find("Autismos").GetComponent<Button>();
        autismos.onClick.AddListener(Love);
        moneyText = GameObject.Find("Money").GetComponent<Text>();
        moneyText.text = money + string.Empty;
        First = GameObject.Find("First").GetComponent<Text>();
        Second = GameObject.Find("Second").GetComponent<Text>();
        Third = GameObject.Find("Third").GetComponent<Text>();
        First.text = string.Empty;
        Second.text = string.Empty;
        Third.text = string.Empty;
        Application.runInBackground = true;
        
    }
	
	// Update is called once per frame
	void Update () {
        moneyText.text = money + string.Empty;
    }

    void Love()
    {
        
        System.Random rnd = new System.Random();
        Third.text = Second.text;
        Second.text = First.text;
        First.text = Phrases[rnd.Next(Phrases.Length)];
        money++;
        moneyText.text = money + string.Empty;
    }
}
