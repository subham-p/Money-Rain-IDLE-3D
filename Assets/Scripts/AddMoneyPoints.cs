using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoneyPoints : MonoBehaviour
{
    [SerializeField] GameObject[] moneyPoints;
    // Start is called before the first frame update
    
    public void AddPoints(){
        foreach (GameObject moneyPoint in moneyPoints)
        {
            if(!moneyPoint.activeSelf) {
                moneyPoint.SetActive(true);
                break;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
