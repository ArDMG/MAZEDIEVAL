using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    //[SerializeField] protected float speedEnemy = 50f;
    //[SerializeField] private     float distanceRay = 10f;
    


    [SerializeField] protected GhostData myData;
    [SerializeField] protected GameObject originOne;

    protected Rigidbody rbGhost;

    private bool isAttack = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myData.GhostName);
        rbGhost = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isAttack)
        {
            FindEnemy();
            Move();
        }
    }

    public virtual void Move()
    {
        Vector3 direction = Vector3.left;
        rbGhost.rotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        rbGhost.AddForce(direction * myData.Speed, ForceMode.Impulse);
    }

    public virtual void FindEnemy()
    {
        BroadCastRaycast(originOne.transform);
    }

    protected void BroadCastRaycast(Transform origen)
    {
        RaycastHit hit;
        if (Physics.Raycast(origen.position, origen.TransformDirection(Vector3.forward), out hit, myData.DistanceRay))
        {
            if (hit.transform.CompareTag("MainCharacter"))
            {
                isAttack = true;
                rbGhost.velocity = Vector3.zero;
            }
        }
    }

    protected void DrawRay(Transform origen)
    {
        Gizmos.color = Color.red;
        Vector3 direction = origen.TransformDirection(Vector3.forward) * myData.DistanceRay;
        Gizmos.DrawRay(origen.position, direction);
    }

    public virtual void DrawRaycast()
    {
        DrawRay(originOne.transform);
    }

    void OnDrawGizmos()
    {
       if (!isAttack)
       {
          DrawRaycast();
      }
    }
}
