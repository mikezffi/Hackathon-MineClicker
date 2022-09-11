using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ladder : MonoBehaviour
{
    public void Reset()
    {
        SceneManager.LoadScene("Mine");
        GameManager.instance.ladder = false;
        GameManager.instance.blockIndex = 0;
        GameManager.instance.nivel++;
    }
}
