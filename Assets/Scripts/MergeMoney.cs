using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeMoney : MonoBehaviour
{
    // Start is called before the first frame update
    bool drag = false;
    Vector3 initalPos;
    [SerializeField] Vector2 tune = Vector2.zero;
    [SerializeField] GameObject SplEffects;

    private void Start() {
        initalPos = transform.localPosition;
    }
    private void OnTriggerEnter(Collider other) {
        // Debug.Log("merged + "+ other.tag);
        if(other.gameObject.tag == "Money" && !drag){
            if(other.GetComponent<ShowDrop>().Value==GetComponent<ShowDrop>().Value && GetComponent<ShowDrop>().Value<GetComponent<ShowDrop>().CurrenicesAvailable){
                SplEffects.SetActive(true);
                GetComponent<ShowDrop>().IncreaseCurrency();
                other.gameObject.GetComponent<ShowDrop>().CurrentCurrency=0;
                other.GetComponent<ShowDrop>().Value=0;
                other.gameObject.SetActive(false);
            }
        }
    }

    void OnMouseUp()
    {
        drag = false;
    } //MouseExit

    void OnMouseDrag()
     {
         Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
         Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
 
         transform.position = new Vector3(objPosition.x+tune.x,objPosition.y+tune.y,transform.position.z);
         drag = true;
        
     }

     void Update() {
         if(!drag)
            transform.localPosition = Vector3.Lerp(transform.localPosition,initalPos,Time.deltaTime*10);
     }

     private void OnDisable() {
          transform.localPosition =initalPos;
          drag = false;
     }
}
