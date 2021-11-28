using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueGhost : Ghost
{
    //[SerializeField] private int shield = 1000;

    [SerializeField] private GameObject player;
    [SerializeField] protected GameObject originTwo;
    [SerializeField] protected GameObject originThree;


    private Vector3 GetPlayerDirection()
    {
        return player.transform.position - transform.position;
    }

    public override void Move()
    {
        Vector3 playerDirection = GetPlayerDirection();
        rbGhost.rotation = Quaternion.LookRotation(new Vector3(playerDirection.x, 0, playerDirection.z));
        rbGhost.AddForce(playerDirection * myData.Speed);
    }

    public override void FindEnemy()
    {
        base.FindEnemy();
        BroadCastRaycast(originTwo.transform);
        BroadCastRaycast(originThree.transform);
    }

    public override void DrawRaycast()
    {
        base.DrawRaycast();
        DrawRay(originTwo.transform);
        DrawRay(originThree.transform);
    }
}
