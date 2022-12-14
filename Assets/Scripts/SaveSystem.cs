using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    private static SaveSystem _instance;

    public static SaveSystem Instance
    {
        get {return _instance; }
    }


    float money;
    float dropSpeed;
    int moneyPoints;
    // Start is called before the first frame update
    void Awake()
    {
       if(_instance !=null && _instance !=this)
       {
        Destroy(this.gameObject);
        return;
       }
       _instance = this;
       DontDestroyOnLoad(this.gameObject);
    }
    
    public float Money { 
        get 
        {
             if(PlayerPrefs.HasKey("Money")) {
                money = PlayerPrefs.GetFloat("Money");
                return money;
             }
             return money =0;
        }
        set
        {
            PlayerPrefs.SetFloat("Money", value);
            money = value;
        }
        }

    public float DropSpeed {
        get 
        {
             if(PlayerPrefs.HasKey("DropSpeed")) {
                dropSpeed = PlayerPrefs.GetFloat("DropSpeed");
                return dropSpeed;
             }
             return dropSpeed = 3f;
        }
        set
        {
            PlayerPrefs.SetFloat("DropSpeed", value);
            dropSpeed = value;
        }
        }

    public int MoneyPoints 
    { 
        get 
        {
             if(PlayerPrefs.HasKey("MoneyPoints")) {
                moneyPoints = PlayerPrefs.GetInt("MoneyPoints");
                return moneyPoints;
             }
             return moneyPoints = 0;
        }
        set
        {
            PlayerPrefs.SetInt("MoneyPoints", value);
            moneyPoints = value;
        }
    }
}
