using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RayNextLevel3 : MonoBehaviour
{
    //public GameObject Door;
    float degreesPerSecond = 20;
    private bool CrossLine = false;

    //public KeyInventory catchKey;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastEnd();
        if (CrossLine == true)
        {
            NextLevel();
        }
    }

    private void RaycastEnd()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.right, out hit, 4f))
        {

            CrossLine = true;

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector3.right * 4f);
    }
    
    private void NextLevel()
    {
        SceneManager.LoadScene("Level3");
        Debug.Log("next level");
    }

}



