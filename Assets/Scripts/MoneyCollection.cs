using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollection : MonoBehaviour
{
    bool collect = false;
    int val;
    private void OnEnable() {
        val =0;
    }
    private void OnTriggerStay(Collider other) {
        if(collect){
            val+=other.transform.parent.gameObject.GetComponent<Drops>().Value;
            other.transform.parent.gameObject.GetComponent<Drops>().Reset();
            other.transform.parent.gameObject.SetActive(false);
            // collect = false;
        }
    }

    public void CollectMoney(){
        collect = true;
        StartCoroutine(CollectionFinish());
    }

    IEnumerator CollectionFinish() {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Value "+val);
        collect = false;
        val=0;
    }
}
