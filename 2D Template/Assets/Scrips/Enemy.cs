using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currenntHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currenntHealth = maxHealth;
    }

   public void TakeDamage(int damage)
    {
        currenntHealth -= damage;

        // Play hurt animation

        if (currenntHealth < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");
        
        // Die animation

        // Disable the enemy
    }

}
