using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static carro;

public class Vehicle : MonoBehaviour, IButtonBehavior
{
    public void ButtonActionA()
    {

        Debug.Log("Cambiando a la siguiente estaci�n de radio");
    }

    public void ButtonActionB()
    {

        Debug.Log("Cambiando a la estaci�n de radio anterior");
    }
}