using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public Transform parent;
    public GameObject ladderObj;
    public static BlockManager instance;

    void Awake() {
        instance = this;
    }

    public void RollLadder(GameObject block){
        if (GameManager.instance.blockIndex == 29)
        {
            SpawnLadder(block.transform.position);
        }
        else
        {
            GameManager.instance.blockIndex++;
            if(Random.Range(0,3) == 1)
            {
                SpawnLadder(block.transform.position);
            }

        }
    }

    private void SpawnLadder(Vector3 vector){
        var x = vector.x + 10;
        var y = vector.y + 10;
        var z = vector.z;
        Instantiate(ladderObj, new Vector3(x, y, z), Quaternion.identity, parent);
        GameManager.instance.drop = "Ladder";
        GameManager.instance.ladder = true;
        SoundManagerScript.PlaySound("LadderFound");
    }
}
