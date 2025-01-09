using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

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

        animator.SetTrigger("Hurt");

        if (currenntHealth < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        animator.SetBool("IsDead", true);
        
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;   
    }

}
