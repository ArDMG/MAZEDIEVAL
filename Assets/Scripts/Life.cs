using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject Player;
    public GameObject Heart;
   
    [SerializeField] public int HeartCount = 1;

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
            Debug.Log("You Died");
            HeartCount = 0;
        }

    }
}
