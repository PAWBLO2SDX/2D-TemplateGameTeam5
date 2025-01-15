using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Health Health;
    public int damage = 2;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnCollisionEnter2D(collision, damage);
    }

    private void OnCollisionEnter2D(Collision2D collision, int damage)
    {
        if (collision.gameObject.tag == "Player")
        {
            Health.TakeDamage(amount: damage);
        }
    }
}
