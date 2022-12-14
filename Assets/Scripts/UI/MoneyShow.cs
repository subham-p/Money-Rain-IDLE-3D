using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyShow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tmp;
    private void Start() {
        tmp.text=SaveSystem.Instance.Money+"$";
    }

    public void MoneyUpdate(){
        tmp.text=SaveSystem.Instance.Money+"$";
    }
}
