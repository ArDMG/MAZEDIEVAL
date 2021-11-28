using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GhostData", menuName = "Ghost Data")]
public class GhostData : ScriptableObject
{
    [SerializeField]
    private string ghostName;
    [SerializeField]
    private int hp;
    [SerializeField]
    private int shield;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float distanceRay;
    [SerializeField]
    private float damageHit;
    //GETTER
    public string GhostName
    {
        get
        {
            return ghostName;
        }
    }

    public int HP
    {
        get
        {
            return hp;
        }
    }

    public int Shield
    {
        get
        {
            return shield;
        }
    }
    public float Speed
    {
        get
        {
            return speed;
        }
    }

    public float DistanceRay
    {
        get
        {
            return distanceRay;
        }
    }
}
