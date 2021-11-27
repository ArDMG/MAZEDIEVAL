using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LandingController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPlay()
    {
        Debug.Log("Start!");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(SceneManager.GetActiveScene().name);
        //SceneManager.LoadSceneAsync("Level1");
        SceneManager.LoadScene("Level1");
    }
}
