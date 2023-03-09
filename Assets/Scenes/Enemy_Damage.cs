using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Damage : MonoBehaviour
{
    public Transform playerTransform;
    public Animator animator;

    public int attackDistance = 2;
    public int attackPower = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, playerTransform.position) <= attackDistance)
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }


/*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {

            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            playerHealth.TakeDamage(attackPower);
        }
    }
    */
}
