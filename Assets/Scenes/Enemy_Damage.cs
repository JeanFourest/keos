using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Damage : MonoBehaviour
{
    public Transform playerTransform;
    public Animator animator;

    public int attackDistance = 2;
    public int attackPower = 2;
    public float attackInterval = 2.0f;

    private bool canAttack = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, playerTransform.position) <= attackDistance && canAttack)
        {
            StartCoroutine(AttackPlayer());
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }

    IEnumerator AttackPlayer()
    {
        canAttack = false;
        animator.SetBool("Attack", true);
        PlayerHealth playerHealth = playerTransform.GetComponent<PlayerHealth>();
        playerHealth.TakeDamage(attackPower);
        yield return new WaitForSeconds(attackInterval);
        canAttack = true;
    }
}
