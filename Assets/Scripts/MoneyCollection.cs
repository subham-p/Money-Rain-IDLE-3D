using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollection : MonoBehaviour
{
    bool collect = false;
    float val;
    private void OnEnable() {
        val =0;
    }
    private void OnTriggerStay(Collider other) {
        if(collect){
            val+=MoneyCount(other.transform.parent.gameObject.GetComponent<Drops>().Value);
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

    float MoneyCount(int val) {
        switch (val)
        {
            case 0:
                return 0.1f;
            case 1:
                return 1f;
            case 2:
                return 5f;
            case 3:
                return 10f;
            case 4:
                return 20f;
            case 5:
                return 100f;
            
            default:
                return 0;
        }

        return 0;
    }
}
