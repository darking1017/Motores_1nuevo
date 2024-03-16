using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public interface IWeapon
    {
        void Equip();
        void Attack();
        void Unequip();
    }


    public interface IArmor
    {
        void Equip();
        void Defend();
        void Unequip();
    }

 
    public interface IPotion
    {
        void Use();
    }


}
