using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : Enemy
{
    public override void Move()
    {
        Debug.Log(name + " moviendo hacia el personaje.");
    }

    public override void Attack()
    {
        Debug.Log(name + " ataque normal.");
    }
}