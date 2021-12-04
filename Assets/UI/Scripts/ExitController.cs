using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Closing Game");
    }
}
