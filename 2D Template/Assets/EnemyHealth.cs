using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maxhealth = 1f;
    private float currentHealth;

    private void start()
    {
        currentHealth = maxhealth;
    }
}
