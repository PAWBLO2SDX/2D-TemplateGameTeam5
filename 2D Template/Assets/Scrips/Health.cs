using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health, maxHealth = 10;
   
    
    
    public Image healthBar;

    

    // Start is called before the first frame update
    public void Start()
    {
        health = maxHealth;
    }
    
       
   
    

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 10);
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        
        if(health <= 0)
        {
            health = 0;
            
            Destroy(gameObject);
        }
    }
}
