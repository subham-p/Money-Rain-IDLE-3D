using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoneyDrops : MonoBehaviour
{
    [SerializeField] GameObject[] moneyDrops;
    // Start is called before the first frame update
    
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
    }
}
