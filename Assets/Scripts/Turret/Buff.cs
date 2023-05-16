using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum BuffType { Damage, Rate, Range }
public class Buff : MonoBehaviour
{
    public BuffType buffType;
    Turret T;
    private void Start()
    {
        T = FindFirstObjectByType<Turret>();
    }

    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.tag == "turret")
        {
            //non mi fa il collider
            Debug.Log("Buff Active");
            if (buffType == BuffType.Damage)
            {
                T.damage += 2f;
                Debug.Log(T.damage);
            }

            if (buffType == BuffType.Rate)
            {
                T.fireRate += 1f;
                Debug.Log(T.fireRate);
            }

            if (buffType == BuffType.Range)
            {
                T.range += 5f;
                Debug.Log(T.range);
            }
        }
    
    }

}
