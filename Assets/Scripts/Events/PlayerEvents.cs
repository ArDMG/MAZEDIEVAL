using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerEvents
{
    public static event Action onDeath;
    public static event Action onGhost;
    public static event Action onFlowers;



    public static void OnDeath()
    {
        onDeath?.Invoke();
    }

    public static void OnGhost()
    {
        onGhost?.Invoke();
    }

    public static void OnFlowers()
    {
        onFlowers?.Invoke();
    }
}
