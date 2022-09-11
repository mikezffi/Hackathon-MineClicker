using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{
    public GameObject block;
    public int currentHP;
    public int maxHP;
    public Image healthBarFill;

    public int dropMod;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = GameManager.instance.nivel * 2;
        maxHP = GameManager.instance.nivel * 2;
        dropMod = Random.Range(0,4);
    }

    public void Reset(){
        dropMod = Random.Range(0,4);
        block.GetComponent<Button>().enabled = true;
        var colors = block.GetComponent<Button>().colors;
        colors.normalColor = new Color32(255, 255, 255, 255);
        block.GetComponent<Button>().colors = colors;
    }

    public void Damage()
    {
        currentHP--;
        healthBarFill.fillAmount = (float)currentHP / (float)maxHP;
        if (currentHP <= 0)
        {   
            SoundManagerScript.PlaySound("StoneBreak");

            block.GetComponent<Button>().enabled = false;
            var colors = block.GetComponent<Button>().colors;
            colors.normalColor = new Color32(183,169, 169, 255);
            block.GetComponent<Button>().colors = colors;
            Drop();
        } else {
            SoundManagerScript.PlaySound("GroundClick");
        }
    }

    public void Drop(){

        GameManager.instance.Roll(dropMod, block);
    }
    
}
