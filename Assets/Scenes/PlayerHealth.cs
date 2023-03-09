using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100; // The player's starting health

    public void TakeDamage(int damage)
    {
        health -= damage; // Subtract the amount of damage from the player's current health

        if (health <= 0)
        {
            // Player is dead, trigger game over event or other appropriate actions
            Destroy(gameObject);

        }
    }
}
