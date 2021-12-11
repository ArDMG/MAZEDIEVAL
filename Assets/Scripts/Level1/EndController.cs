using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndController : MonoBehaviour
{
    //public GameObject Door;
    float degreesPerSecond = 20;
    public KeyInventory KeyInventory;
    public GameObject Door;
    [SerializeField] private GameObject levelComplete;

    //public KeyInventory catchKey;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        RaycastEnd();
    }

    [System.Obsolete]
    private void RaycastEnd()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 4f))
        {
            
            Destroy(gameObject);
            UnlockDoor();

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector3.forward * 4f);
    }

    [System.Obsolete]
    public void UnlockDoor()
    {
        if ( KeyInventory.HaveTheKey == true)
        {
            Door.transform.eulerAngles = new Vector3(0f, 90f, 0f);
            //Door.transform.eulerAngles = new Vector3(0, degreesPerSecond, 0) * Time.deltaTime;
            Debug.Log("Time End");
            GameManager.score += 100;
            Debug.Log("Level 1 Completed! Your Score: " + GameManager.score);
            levelComplete.active = true;

        }
    }
}



