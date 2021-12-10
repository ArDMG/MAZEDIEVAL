using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDControllerLevel3 : MonoBehaviour
{
   
    private CharacterController playerScript;

    [SerializeField] private GameObject endScreen;


    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        PlayerEvents.onDeath += GameOver;
        endScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

   
    [System.Obsolete]
    public void GameOver()
    {
        //endScreen.SetActive(true);
        StartCoroutine(ActivateEndScreen());
    }

    [System.Obsolete]
    IEnumerator ActivateEndScreen()
    { 
        yield return new WaitForSeconds(4f);
        Debug.Log("activating...");
        //GameObject.Find("EndPanel").active = true;
        endScreen.SetActive(true);

    }
}
