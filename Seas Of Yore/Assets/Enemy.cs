using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float curHealth;
    public float maxHealth;

    private void Start()
    {
        curHealth = maxHealth;
    }

    private void Update()
    {
        if(curHealth <= 0)
        {
            Die();
        }
    }
    public void TakeDamage(float dmgAmt)
    {
        curHealth -= dmgAmt;
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
