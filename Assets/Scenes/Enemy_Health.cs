using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int healthEnemy = 100;

    public void TakeDamageEnemy(int damageEnemy)
    {
        healthEnemy -= damageEnemy;

        if (healthEnemy <= 0)
        {

            Destroy(gameObject);

        }
    }
}
