using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndController3 : MonoBehaviour
{
    //public GameObject Door;
    public GameObject FX;
    public GameObject Sword;

    private bool FXActive = false;

    //public KeyInventory catchKey;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastEnd();
    }

    private void RaycastEnd()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 4f))
        {
            
            //Destroy(gameObject);
            ActivateFX();
            StartCoroutine(Timer());
            DeactivateFX();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector3.forward * 4f);
    }

    public void ActivateFX()
    {       
            GameManager.score += 1000;
            Debug.Log("Game Completed! Your Score: " + GameManager.score);
            FX.SetActive(true);
            Sword.SetActive(true);



    }

    public void DeactivateFX()
    {
        
        FX.SetActive(true);


    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Timer End");
        //GameObject.Find("EndPanel").active = true;
        FX.SetActive(false);


    }
    
}




