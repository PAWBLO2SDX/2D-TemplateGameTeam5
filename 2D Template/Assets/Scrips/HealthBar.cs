using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour

{
    private float _maxHealth = 100;
    private float _currentHealth;
    public Slider slider;
    public Image fill;

    private void Awake()
    {
        _currentHealth = _maxHealth;

    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        
    }

    public void SetHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        
       
    }
    
}
