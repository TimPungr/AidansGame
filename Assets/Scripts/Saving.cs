using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


public class Saving : MonoBehaviour {

    public Achievemnts ach;
    public ShopSim sim;
    public ShopStuff shop;
    public Money mon;
    public scorer sco;
    public Game fnv;
    public Game r6;
    public Game ds;
    public Game poe;
    public Game pay;
    public Game sky;



	// Use this for initialization
	void Start () {
        ach = GameObject.Find("MainLogic").GetComponent<Achievemnts>();
        shop = GameObject.Find("MainLogic").GetComponent<ShopStuff>();
        mon = GameObject.Find("MainLogic").GetComponent<Money>();
        sco = GameObject.Find("MainLogic").GetComponent<scorer>();
        sim = GameObject.Find("Sims").GetComponent<ShopSim>();
        Debug.Log(Application.persistentDataPath);
        fnv = GameObject.Find("FNV").GetComponent<Game>();
        poe = GameObject.Find("POE").GetComponent<Game>();
        r6 = GameObject.Find("R6").GetComponent<Game>();
        ds = GameObject.Find("DS").GetComponent<Game>();
        pay = GameObject.Find("Payday2").GetComponent<Game>();
        sky = GameObject.Find("Skyrim").GetComponent<Game>();

        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            ach.first = save.first;
            ach.second = save.second;
            ach.third = save.third;
            sim.owned = save.simOwned;
            sim.price = save.simPrice;
            shop.sModifier = save.sModifier;
            shop.mModifier = save.mModifier;
            shop.sAdd = save.sAdd;
            shop.mAdd = save.mAdd;
            sco.score = save.score;
            mon.money = save.money;
            if (save.fnv)
            {
                fnv.Activate();
            }
            if (save.r6)
            {
                r6.Activate();
            }
            if (save.poe)
            {
                poe.Activate();
            }
             if (save.ds)
             {
                 ds.Activate();
             }
             if (save.pay)
             {
                 pay.Activate();
             }
             if (save.sky)
             {
                 sky.Activate();
             }


        }
        else
        {

            Debug.Log("Fuck you, you ain't got a save");
        }


    }
	
    private Save SaveGame()
    {
        Save save = new Save();


        save.first = ach.first;
        save.second = ach.second;
        save.third = ach.third;
        save.simOwned = sim.owned;
        save.simPrice = sim.price;
        save.sModifier = shop.sModifier;
        save.mModifier = shop.mModifier;
        save.sAdd = shop.sAdd;
        save.mAdd = shop.mAdd;
        save.score = sco.score;
        save.money = mon.money;

        save.poe = poe.bought;
        save.r6 = r6.bought;
        save.ds = ds.bought;
        save.fnv = fnv.bought;
        save.sky = sky.bought;
        save.pay = pay.bought;



        return save;
    }

    private void OnApplicationQuit()
    {
        Save save = SaveGame();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream savefile = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(savefile, save);
        savefile.Close();
    }

}
