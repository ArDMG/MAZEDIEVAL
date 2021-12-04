using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int score;
    public enum typeKey { Key };
    public CharacterController playerScript;
    public GameObject CharacterController;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            score = 0;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    [Obsolete]
    private void Start()
    {
        PlayerEvents.onDeath += GameOver;


    }

    [Obsolete]
    public void GameOver()
    {
        score = 0;
        Debug.Log ("Score reset to 0");
        GameObject.Find("Maze").active = false;
        GameObject.Find("Wall").active = false;
        GameObject.Find("Lights").active = false;
        GameObject.Find("Lamp").active = false;
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
