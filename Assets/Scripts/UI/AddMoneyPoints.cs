using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoneyPoints : MonoBehaviour
{
    [SerializeField] GameObject[] moneyPoints;
    MoneyPointsRenderer moneyPointsRenderer;
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
    }
    void Start()
    {
        moneyPointsRenderer = FindObjectOfType<MoneyPointsRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
