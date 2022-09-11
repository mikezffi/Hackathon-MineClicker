using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private string[] LootBox = {"Empty", "Empty", "Gold", "Chest"};
    public string drop;
    public int gold;

    public int blockIndex = 0;
    public bool ladder = false;

    public int nivel;

    public static GameManager instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void Roll(int dropMod, GameObject block){
        SoundManagerScript.PlaySound("CoinFound");
        drop = null;
        if(ladder == false)
        {
            BlockManager.instance.RollLadder(block);
        }

        if(drop != "Ladder")
        {
            drop = LootBox[dropMod];
            if (dropMod == 2)
            {
                gold++;
            }
        }
    }
}
