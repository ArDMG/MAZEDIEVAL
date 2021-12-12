using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    private bool isActiveMENU = false;
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Escape) && isActiveMENU == false)
        {
            Debug.Log("ActivatePause");
            PauseMenu.SetActive(true);
            isActiveMENU = true;
            Cursor.lockState = CursorLockMode.None;

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape) && isActiveMENU == true)
            { 
              Debug.Log("DeactivatePause");
            PauseMenu.SetActive(false);
            isActiveMENU = false;
            Cursor.lockState = CursorLockMode.Confined;
            }
        }
        }
    }
    //private void DeactivePause()
    //{
       // if (isActiveMENU == true && Input.GetKeyDown(KeyCode.Escape))
      //  {
   //         Debug.Log("DeactivatePause");
     //       PauseMenu.SetActive(true);
      //      isActiveMENU = false;
//
//
    //    }
   // }
//}
