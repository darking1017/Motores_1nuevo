using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static carro;

public class Vehicle : MonoBehaviour, IButtonBehavior
{
    public void ButtonActionA()
    {

        Debug.Log("Cambiando a la siguiente estación de radio");
    }

    public void ButtonActionB()
    {

        Debug.Log("Cambiando a la estación de radio anterior");
    }
}