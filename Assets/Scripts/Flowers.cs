using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Flowers : MonoBehaviour
{

    public event Action onFlowers;

    // Start is called before the first frame update
    void Start()
    {
        PlayerEvents.onFlowers += TouchFlowers;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TouchFlowers()
    {
        Destroy(this.gameObject);
    }
}
