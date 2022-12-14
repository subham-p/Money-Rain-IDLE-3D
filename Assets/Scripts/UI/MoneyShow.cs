using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyShow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tmp;
    private void Start() {
        MoneyUpdate();
    }

    public void MoneyUpdate(){
        tmp.text=SaveSystem.Instance.Money.ToString("F2")+"$";
    }
}
