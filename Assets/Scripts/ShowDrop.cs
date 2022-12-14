using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDrop : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int currentCurrency=0;
    [SerializeField] GameObject[] currencies;
    int value;
    MoneyRain moneyRain;


    public int Value { get => value; set => this.value = value; }
    public int CurrenicesAvailable { get => currencies.Length-1; }
    public int CurrentCurrency { get => currentCurrency; set => currentCurrency = value; }

    private void OnEnable() {
        Value = CurrentCurrency;
        moneyRain = transform.GetComponentInParent<MoneyRain>();
        moneyRain.enabled = true;
        ShowCurrency();
    }
    void Start()
    {
        // ShowCurrency();
    }

    public void ShowCurrency()
    {
        // currentCurrency=0;
        Value =CurrentCurrency;
        foreach (GameObject curency in currencies)
        {
            if (curency == currencies[CurrentCurrency])
            {
                curency.SetActive(true);
                break;
            }
            curency.SetActive(false);
        }
    }

    public void IncreaseCurrency() {
        CurrentCurrency+=1;
        value=CurrentCurrency;
        ShowCurrency();
    }

    private void OnDisable() {
        CurrentCurrency=0;
        moneyRain.enabled = false;
        foreach (GameObject curency in currencies)
        {
            curency.SetActive(false);
        }
    }



}
