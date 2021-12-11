using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonController : MonoBehaviour
{
    public GameObject HTPText;
    public GameObject ButtonHowtoPlay;
    public GameObject ButtonExit;
    public GameObject ButtonPlay;
    public GameObject BackButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    public void OnClickBackButton()
    {
        ButtonHowtoPlay.SetActive(true);
        ButtonExit.SetActive(true);
        ButtonPlay.SetActive(true);
        HTPText.SetActive(false);
        BackButton.SetActive(false);
    }
}
