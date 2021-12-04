using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HTPController : MonoBehaviour
{
    [System.Obsolete]
    private void Start()
    {
        GameObject.Find("HowToPlay").active = false;

    }
    [System.Obsolete]
    public void OnClickHowToPlay()
    {
        Debug.Log("How To Play!");
        GameObject.Find("ButtonHTP").active = false;
        GameObject.Find("ButtonPlay").active = false;
        GameObject.Find("ButtonExit").active = false;
        ActiveHowToPlay();
    }

    [System.Obsolete]
    private void ActiveHowToPlay()
    {
        GameObject.Find("HowToPlay").active = true;

    }
}


