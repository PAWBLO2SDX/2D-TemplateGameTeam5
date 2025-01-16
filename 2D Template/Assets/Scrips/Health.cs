using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health, maxHealth;
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;
    public Image healthBar;


    

    // Start is called before the first frame update
    public void Start()
    {
        health = maxHealth;
    } 
    public void TakeDamage(int amount)
    {
        health -= amount;
        OnPlayerDamaged?.Invoke();
        
        if(health <= 0)
        {
           
        }
    }
}
