using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drops : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField]
    [SerializeField] GameObject[] currencies;
    GameObject parent;
    Vector3 initialPos;
    ShowDrop showDrop;

    int value;

    public int Value { get => value; set => this.value = value; }

    void OnEnable()
    {
        parent= transform.parent.gameObject;
        initialPos = transform.localPosition;
        // if(parent.GetComponentInChildren<ShowDrop>()!=null){
        // showDrop = parent.GetComponentInChildren<ShowDrop>();
        // // Debug.Log(showDrop.Value);
        // foreach (GameObject curency in currencies)
        // {
        //     if (curency == currencies[showDrop.Value])
        //     {
        //         curency.SetActive(true);
        //         break;
        //     }
        //     curency.SetActive(false);
        // }
        // }

       
    }

    private void Start() {
    //    parent= transform.parent.gameObject;
    //     initialPos = transform.localPosition;
        if(parent.GetComponentInChildren<ShowDrop>()!=null){
        showDrop = parent.GetComponentInChildren<ShowDrop>();
            Value = showDrop.CurrentCurrency;
        // Debug.Log(showDrop.Value);
        foreach (GameObject curency in currencies)
        {
            if (curency == currencies[showDrop.CurrentCurrency])
            {
                curency.SetActive(true);
                break;
            }
            curency.SetActive(false);
        }
        }
        // currencies[showDrop.Value].SetActive(true);
    }
    
    public void Reset() {
        transform.SetParent(parent.transform);
        transform.localPosition=initialPos;
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
