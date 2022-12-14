using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyRain : MonoBehaviour
{
    [SerializeField] GameObject [] rainDrops;
    [SerializeField] GameObject dropsHolder;
    Transform initalPos;
    float fallTimer=2f;
    AddDropSpeed addDropSpeed;


    // Start is called before the first frame update
    void Start()
    {
        if(dropsHolder.activeSelf){
            
            StartCoroutine("moneyRains");
        }
        initalPos=transform;
        addDropSpeed = FindObjectOfType<AddDropSpeed>();
        fallTimer=addDropSpeed.DropSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // if(!dropsHolder.activeSelf)
        //     StopCoroutine("moneyRains");
    }

    IEnumerator moneyRains() {
        int x=0;
        foreach (GameObject drops in rainDrops)
        {
            if(drops.activeSelf)
                continue;
            if(!drops.activeSelf && dropsHolder.activeSelf){
                drops.SetActive(true);
                drops.transform.SetParent(null);
            }
            // StopCoroutine("moneyRains");
            yield return new WaitForSeconds(fallTimer);
            x++;
        }
        // yield return new WaitForSeconds(fallTimer);
        // rainDrops[0].SetActive(true);
        // rainDrops[0].transform.SetParent(null);
        // GameObject gm = Instantiate(rainDrops[0],initalPos);
        // gm.transform.SetParent(null);
        // gm.transform.localScale= Vector3.one/5;
            // yield return new WaitForSeconds(2f);
            Debug.Log("MN"+rainDrops.Length + " n "+ x);
        if(x!=0)
            StartCoroutine("moneyRains");
        if(x==0)
            StopCoroutine("moneyRains");
        // Debug.Log("Checking");
    }

    public void ChangeDropSpeed(bool drag) {
        fallTimer= drag? 0.3f: addDropSpeed.DropSpeed;
         StopCoroutine("moneyRains");
         StartCoroutine("moneyRains");
    }
}
