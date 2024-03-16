using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Enemy : MonoBehaviour
{
   [SerializeField] public string name;
    public int health;

    public abstract void Move();
    public abstract void Attack();
}

