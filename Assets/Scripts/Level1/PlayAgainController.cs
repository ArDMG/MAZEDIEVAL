using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgainController : MonoBehaviour
{
    [System.Obsolete]
    public void OnClickReplay()
    {
        Debug.Log("Start!");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(SceneManager.GetActiveScene().name);
        //SceneManager.LoadSceneAsync("Level1");
        SceneManager.LoadScene("Level1");
    }
}
