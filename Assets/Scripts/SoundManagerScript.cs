using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip CoinFoundSound, GroundClickSound, StoneBreakSound, LadderFoundSound, BGM;
    static AudioSource AudioSrc;
    // Start is called before the first frame update
    void Start()
    {
        CoinFoundSound = Resources.Load<AudioClip>("coin-found");
        GroundClickSound = Resources.Load<AudioClip>("ground-click");
        StoneBreakSound = Resources.Load<AudioClip>("stone-break");
        LadderFoundSound = Resources.Load<AudioClip>("ladder-found");
        BGM = Resources.Load<AudioClip>("BGM");

        AudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch (clip)
        {
            case "CoinFound":
                AudioSrc.PlayOneShot(CoinFoundSound);
                break;
            case "GroundClick":
                AudioSrc.PlayOneShot(GroundClickSound);
                break;
            case "StoneBreak":
                AudioSrc.PlayOneShot(StoneBreakSound);
                break;
            case "LadderFound":
                AudioSrc.PlayOneShot(LadderFoundSound);
                break;
        }
    }
}
