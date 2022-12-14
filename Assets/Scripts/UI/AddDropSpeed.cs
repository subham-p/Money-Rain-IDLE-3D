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
        DropSpeed= SaveSystem.Instance.DropSpeed;
    }
    
    public void AddSpeed(){
        DropSpeed-=0.25f;
        SaveSystem.Instance.DropSpeed=DropSpeed;
        foreach (MoneyRain item in moneyRains)
         {
             item.ChangeDropSpeed(false);
         }
    }
}
