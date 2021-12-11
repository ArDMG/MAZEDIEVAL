using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    [SerializeField] private Text textKey;

    [SerializeField] private KeyInventory mgInventory;
    [SerializeField] private GameObject panelKey;
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
        UpdateKeyUI();
    }

    void UpdateKeyUI()
    {
        int[] keyCount = mgInventory.GetKeyQuantity();
        textKey.text =  keyCount[0] +"/1";
      
    }

    public void TooglePanel()
    {
        panelKey.SetActive(!panelKey.activeSelf);
    }

    private void OnDeadHandler()
    {
        textKey.text = "GAME OVER";
    }

    [System.Obsolete]
    public void GameOver()
    {
        //endScreen.SetActive(true);
        GameObject.Find("KeyPanel").active = false;
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

    public void OnClickReplay()
    {
        Debug.Log("Start!");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(SceneManager.GetActiveScene().name);
        //SceneManager.LoadSceneAsync("Level1");
        SceneManager.LoadScene("Level1");
    }
}
