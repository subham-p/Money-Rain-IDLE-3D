using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPointValue : MonoBehaviour
{
   [SerializeField] int value =0;

    public int Value { get => value; set => this.value = value; }
}
