using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudShake : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] float distance=0;
    MoneyRain[] moneyRains;
    Vector3 initalPos;
    bool drag = false;
    bool once = true;

    public bool Drag { get => drag; set => drag = value; }

    // Start is called before the first frame update
    void Start()
    {
        initalPos=transform.position;
        moneyRains= FindObjectsOfType<MoneyRain>();
    }


    // Update is called once per frame
    void Update()
    {
        // if(Input.touchCount>0) {
        //     theTouch=Input.GetTouch(0);
        //     if(theTouch.phase==TouchPhase.Moved){
        //         Debug.Log("Working");
        //     }
        // }
    
    // If no mouse drag then return to original position smoothly
    if(!Drag)
        transform.position = Vector3.Lerp(transform.position,initalPos,Time.deltaTime*10);
    }

    void OnMouseUp()
    {
        Drag = false;
        //Change the speed of money rain
        foreach (MoneyRain item in moneyRains)
         {
             item.ChangeDropSpeed(false);
         }
         once = true;
    } //MouseExit

    // Drag Game Object creating cloudShake effect
    void OnMouseDrag()
     {
         Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
         Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
 
         transform.position = new Vector3(objPosition.x,objPosition.y,transform.position.z);
         Drag = true;

         //Change the speed of money rain only once
         if(once){
            moneyRains= FindObjectsOfType<MoneyRain>();
             once = false;
            foreach (MoneyRain item in moneyRains)
            {
                item.ChangeDropSpeed(true);
            }
         }
     }
}
