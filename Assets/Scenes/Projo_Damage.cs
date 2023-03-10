using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projo_Damage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.TryGetComponent<Enemy_Health>(out Enemy_Health enemyComponent))
        {
            enemyComponent.TakeDamageEnemy(1);
            Destroy(gameObject);
        }
    }
}
