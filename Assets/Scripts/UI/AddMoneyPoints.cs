using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddMoneyPoints : MonoBehaviour
{
    [SerializeField] GameObject[] moneyPoints;
    [SerializeField] float[] moneyDeduction;
    [SerializeField]  TextMeshProUGUI tmp;
    MoneyPointsRenderer moneyPointsRenderer;
    MoneyShow moneyShow;
    float mnd;
    // Start is called before the first frame update
    
    public void AddPoints(){
        foreach (GameObject moneyPoint in moneyPoints)
        {
            if(!moneyPoint.activeSelf) {
                moneyPoint.SetActive(true);
                SaveSystem.Instance.MoneyPoints+=1;
                moneyPointsRenderer.RenderPoints();
                break;
            }
        }
        Debug.Log(SaveSystem.Instance.Money);
        SaveSystem.Instance.Money -= mnd;
        moneyShow.MoneyUpdate();
    }
    void Start()
    {
        moneyPointsRenderer = FindObjectOfType<MoneyPointsRenderer>();
        moneyShow = FindObjectOfType<MoneyShow>();
    }

    // Update is called once per frame
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
