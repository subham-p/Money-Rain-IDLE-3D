using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddDropSpeed : MonoBehaviour
{
    [SerializeField] float dropSpeed=2f;
    MoneyRain[] moneyRains;
    [SerializeField] float[] moneyDeduction;
    [SerializeField]  TextMeshProUGUI tmp;

    float mnd;

    public float DropSpeed { get => dropSpeed; set => dropSpeed = value; }

    private void OnEnable() {
        moneyRains= FindObjectsOfType<MoneyRain>();
        DropSpeed= SaveSystem.Instance.DropSpeed;
    }
    
    public void AddSpeed(){
        DropSpeed-=0.25f;
        if(DropSpeed<=0)
            return;
        SaveSystem.Instance.DropSpeed=DropSpeed;
        foreach (MoneyRain item in moneyRains)
         {
             item.ChangeDropSpeed(false);
         }
    }

     void Update()
    {
        mnd=moneyDeduction[12%currentDropSpeed()];
        // Debug.Log("MND"+(12%currentDropSpeed()));
        tmp.text=mnd+"$";
        if(mnd> SaveSystem.Instance.Money)
            GetComponent<Button>().interactable = false;
        else
            GetComponent<Button>().interactable = true;
    }

    int currentDropSpeed(){
        float speed=DropSpeed;
        int sp=0;
        sp = (int) ((speed/0.25f));
        return sp;
    }
}
