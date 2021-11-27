using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField] private Text textKey;

    [SerializeField] private KeyInventory mgInventory;
    [SerializeField] private GameObject panelKey;

    // Start is called before the first frame update
    void Start()
    {

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
}
