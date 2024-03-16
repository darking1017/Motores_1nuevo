using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebacarro : MonoBehaviour
{
    void Start()
    {
        
        Player player = new Player();

       
        player.ButtonActionA();

      
        player.ButtonActionB();

       
        Vehicle vehicle = new Vehicle();

      
        vehicle.ButtonActionA();

        
        vehicle.ButtonActionB();
    }
}
