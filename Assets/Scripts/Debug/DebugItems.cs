using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugItems : MonoBehaviour
{
    [SerializeField] Camera camera;
    // Start is called before the first frame update
    MoneyShow moneyShow;

    private void OnEnable() {
        moneyShow = FindObjectOfType<MoneyShow>();
    }

    public void CameraFOVIncrease(){
        camera.fieldOfView+=5f;
    }
    public void CameraFOVDecrease(){
        camera.fieldOfView-=5f;
    }
    public void CameraBackGround(string str){
        //def, red, yel
        // Color32()
        switch(str) {
            case "default":
                camera.backgroundColor= new Color32(156,165, 180, 1);
                Debug.Log("Smth");
                break;
            case "red":
                camera.backgroundColor= new Color32(167,202, 142,1);
                break;
            case "yellow":
                camera.backgroundColor= new Color32(231,213, 114,1);
                break;
            case "blue":
                camera.backgroundColor= new Color32(114,178, 231,1);
                break;
        }

    }

    public void AddMoney(){
        SaveSystem.Instance.Money += 1000;
        moneyShow.MoneyUpdate();
    }

    public void RemoveMoney() {
        SaveSystem.Instance.Money -= 500;
        moneyShow.MoneyUpdate();

    }

}
