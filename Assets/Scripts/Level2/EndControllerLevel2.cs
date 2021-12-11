using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndControllerLevel2 : MonoBehaviour
{
    //public GameObject Door;
    float degreesPerSecond = 20;
    public KeyInventory KeyInventory;
    public GameObject Door;

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

        if (Physics.Raycast(transform.position, Vector3.right, out hit, 4f))
        {
            
            //Destroy(gameObject);
            UnlockDoor();

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector3.right * 4f);
    }

    public void UnlockDoor()
    {
        if ( KeyInventory.HaveTheKey == true)
        {
            Door.transform.eulerAngles = new Vector3(0f, 90f, 0f);
            //Door.transform.eulerAngles = new Vector3(0, degreesPerSecond, 0) * Time.deltaTime;
            Debug.Log("Time End");
            GameManager.score += 100;
            Debug.Log("Level 1 Completed! Your Score: " + GameManager.score);
        }
    }
}



