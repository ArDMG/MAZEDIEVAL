using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Life : MonoBehaviour
{
    public GameObject Player;
    public GameObject Heart;
   
    [SerializeField] public int HeartCount = 1;

    //Events
    public event Action onDeath;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    void OnCollisionEnter(Collision other)
        {
        if (other.gameObject.CompareTag("Arrow"))
        {
            DestroyObject(Heart);
            HeartCount = 0;
        }

    }
}
