using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static carro;

public class Player : MonoBehaviour, IButtonBehavior
{
    public void ButtonActionA()
    {

        Debug.Log("Realizando emoji");
    }

    public void ButtonActionB()
    {

        Debug.Log("Agachándose");
    }
}
