using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider slider;

    void Start()
    {
        currentHealth = maxHealth;
        slider.value = maxHealth;  
    }

    void Update()
    {
        slider.value = currentHealth;
        
        if (currentHealth <= 0) 
        { 
            //Game Over
        }

    }



}
