using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI dropText;
    // Start is called before the first frame update
    void Start()
    {
        goldText.text = "$" + GameManager.instance.gold.ToString();
        dropText.text = GameManager.instance.drop;
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = "$" + GameManager.instance.gold.ToString();
        dropText.text = GameManager.instance.drop;
    }
}
