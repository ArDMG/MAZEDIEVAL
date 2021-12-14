using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Flowers : MonoBehaviour
{

    public event Action onFlowers;

    // Start is called before the first frame update
    [Obsolete]
    void Start()
    {
        PlayerEvents.onFlowers += TouchFlowers;
        GameObject.Find("Flowers").active = true;

    }

    // Update is called once per frame
    void Update()
    {

    }

    [Obsolete]
    public void TouchFlowers()
    {
        //Destroy(this.gameObject);
        GameObject.Find("Flowers").active = false;

    }
}
