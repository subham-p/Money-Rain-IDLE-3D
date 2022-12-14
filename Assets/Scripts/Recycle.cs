using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
         other.transform.parent.gameObject.GetComponent<Drops>().Reset();
        other.transform.parent.gameObject.SetActive(false);
    }
}
