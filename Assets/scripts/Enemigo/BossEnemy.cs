using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossEnemy : Enemy
{
    public override void Move()
    {
        Debug.Log(name + " corre al persoanje.");
    }

    public override void Attack()
    {
        Debug.Log(name + " ataque fuerte!");
    }
}

