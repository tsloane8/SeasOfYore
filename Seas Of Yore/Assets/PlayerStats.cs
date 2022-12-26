using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float moveSpeedMultiplier;
    [Header("Attack Variables")]
    public float attackSpeed;
    public float attackSpeedMultiplier;
    public float attackDamage;
    public float attackDamageMultiplier;
    public float attackRange;
    public float attackRangeMultiplier;
    [Header("Crit Variables")]
    public float critChance;
    public float critChanceMultiplier;
    public float critDamage;
    public float critDamageMultiplier;
    [Header("Health and Defence Variables")]
    public float healthAmount;
    public float healthAmountMultiplier;
    public float defenceAmount;
    public float defenceAmountMultiplier;

    private void Update()
    {
        CalculateStats();
    }
    private void CalculateStats()
    {
        moveSpeed *= moveSpeedMultiplier;
        attackSpeed *= attackSpeedMultiplier;
        attackDamage *= attackDamageMultiplier;
        attackRange *= attackRangeMultiplier;
        critChance *= critChanceMultiplier;
        critDamage *= critDamageMultiplier;
        healthAmount *= healthAmountMultiplier;
        defenceAmount *= defenceAmountMultiplier;
    }
}

