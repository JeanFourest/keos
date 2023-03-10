using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    [SerializeField] float healthEnemy = 100f;
    public void TakeDamageEnemy(int damageEnemy)
    {
        healthEnemy -= damageEnemy;

        if (healthEnemy <= 0)
        {

            Destroy(gameObject);

        }
    }
}
