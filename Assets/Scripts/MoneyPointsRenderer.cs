using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPointsRenderer : MonoBehaviour
{
    [SerializeField] GameObject[] moneyPoints;
    private void OnEnable()
    {
        RenderPoints();

    }

    public void RenderPoints()
    {
        int x = 0;
        int number = SaveSystem.Instance.MoneyPoints;
        foreach (GameObject moneyPoint in moneyPoints)
        {
            moneyPoint.SetActive(true);
            moneyPoint.GetComponent<MoneyPointValue>().Value=x;
            if (x == number)
            {
                break;
            }
            x++;
        }
    }
    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
