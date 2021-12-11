using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HTPController : MonoBehaviour
{


    public GameObject HTPText;
    public GameObject ButtonHowtoPlay;
    public GameObject ButtonExit;
    public GameObject ButtonPlay;
    public GameObject BackButton;

    private void Start()
    {
        ButtonHowtoPlay.SetActive(true);
        ButtonExit.SetActive(true);
        ButtonPlay.SetActive(true);
        HTPText.SetActive(false);
        BackButton.SetActive(false);

    }


    public void OnClickHowToPlay()
    {
        ButtonHowtoPlay.SetActive(false);
        ButtonExit.SetActive(false);
        ButtonPlay.SetActive(false);
        HTPText.SetActive(true);
        BackButton.SetActive(true);
    }
}


