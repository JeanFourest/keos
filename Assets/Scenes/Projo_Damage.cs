using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projo_Damage : MonoBehaviour
{

    public Transform enemyTransform;
    public Animator animator2;

    public int attackDistanceBullet = 1;
    public int attackPowerBullet = 100;
    public float attackIntervalBullet = 0;

    private bool canAttackBullet = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, enemyTransform.position) <= attackDistanceBullet && canAttackBullet)
        {
            StartCoroutine(AttackEnemy());
        }
        else
        {
            animator2.SetBool("Attack", false);
        }
    }

    IEnumerator AttackEnemy()
    {
        canAttackBullet = false;
        animator2.SetBool("Attack", true);
        Enemy_Health EnemyHealth = enemyTransform.GetComponent<Enemy_Health>();
        EnemyHealth.TakeDamageEnemy(attackPowerBullet);
        yield return new WaitForSeconds(attackIntervalBullet);
        canAttackBullet = true;
    }
}
