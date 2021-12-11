using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HTPController : MonoBehaviour
{

    public GameObject HTPText;
    [System.Obsolete]
    private void Start()
    {
        HTPText.SetActive(false);
    }

   

    [System.Obsolete]
    public void OnClickHowToPlay()
    {
        Debug.Log("How To Play");
        GameObject.Find("ButtonHowToPlay").active = false;
        GameObject.Find("ButtonPlay").active = false;
        GameObject.Find("ButtonExit").active = false;
        HTPText.SetActive(true);
    }
}


