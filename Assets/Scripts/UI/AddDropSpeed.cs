using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDropSpeed : MonoBehaviour
{
    [SerializeField] float dropSpeed=2f;
    MoneyRain[] moneyRains;

    public float DropSpeed { get => dropSpeed; set => dropSpeed = value; }

    private void OnEnable() {
        moneyRains= FindObjectsOfType<MoneyRain>();
    }
    
    public void AddSpeed(){
        DropSpeed-=0.25f;
        foreach (MoneyRain item in moneyRains)
         {
             item.ChangeDropSpeed(false);
         }
    }
}
