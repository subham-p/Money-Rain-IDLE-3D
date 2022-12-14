using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddMoneyDrops : MonoBehaviour
{
    [SerializeField] GameObject[] moneyDrops;
    [SerializeField] float[] moneyDeduction;
    [SerializeField]  TextMeshProUGUI tmp;
    MoneyPointsRenderer moneyPointsRenderer;
    MoneyShow moneyShow;
    float mnd;

    
    public void AddDrops(){
        foreach (GameObject moneyDrop in moneyDrops)
        {
            if(!moneyDrop.activeSelf) {
                moneyDrop.SetActive(true);
                moneyDrop.GetComponent<ShowDrop>().CurrentCurrency=0;
                moneyDrop.GetComponent<ShowDrop>().Value=0;
                break;
            }
        }
        SaveSystem.Instance.Money -= mnd;
        moneyShow.MoneyUpdate();
    }
    void Start()
    {
        moneyShow = FindObjectOfType<MoneyShow>();
        moneyPointsRenderer = FindObjectOfType<MoneyPointsRenderer>();
    }
     void Update()
    {
        mnd=moneyDeduction[SaveSystem.Instance.MoneyPoints];
        tmp.text=mnd+"$";
        if(mnd> SaveSystem.Instance.Money)
            GetComponent<Button>().interactable = false;
        else
            GetComponent<Button>().interactable = true;
    }
}
