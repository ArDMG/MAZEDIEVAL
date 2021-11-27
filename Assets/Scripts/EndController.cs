using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndController : MonoBehaviour
{
    public GameObject Door;
    float degreesPerSecond = 20;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastStart();
    }

    private void RaycastStart()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 4f))
        {
            Debug.Log("Time End");
            GameManager.score += 100;
            Debug.Log("Level 1 Completed! Your Score: " + GameManager.score);
            Destroy(gameObject);
            UnlockDoor();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector3.forward * 4f);
    }

    private void UnlockDoor()
    {
        Door.transform.eulerAngles = new Vector3(0f, 90f, 0f);
        //Door.transform.eulerAngles = new Vector3(0, degreesPerSecond, 0) * Time.deltaTime;

    }
}



