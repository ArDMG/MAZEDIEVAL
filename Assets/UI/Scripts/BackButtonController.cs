using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BackButtonController : MonoBehaviour
{

    public GameObject HTPText;
    public GameObject BackButton;
    public GameObject ButtonHowtoPlay;
    public GameObject ButtonExit;
    public GameObject ButtonPlay;

    [System.Obsolete]
    private void Start()
    {
        GameObject.Find("HowToPlayText").active = false;
    }

    [System.Obsolete]
    public void OnClickBackButton()
    {
        Debug.Log("How To Play");
        ButtonHowtoPlay.SetActive(true);
        ButtonExit.SetActive(true);
        ButtonPlay.SetActive(true);
        HTPText.SetActive(false);
        BackButton.SetActive(false);

    }
}


