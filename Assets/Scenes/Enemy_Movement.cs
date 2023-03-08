using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_Movement : MonoBehaviour
{
    public int speed;
    public Transform playerTransform;
    public float chaseDistance; 
    public bool isChasing;
    public Animator animator;


    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isChasing == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        }

        if(Vector2.Distance(transform.position, playerTransform .position) <= chaseDistance)
        {
            isChasing = true;
            int speed = 3;
            animator.SetFloat("Speed", (float)speed); 
        } 
        else
        {
            isChasing = false;
            int speed = 0;
            animator.SetFloat("Speed", (float)speed); 
        }

        this.spriteRenderer.flipX = playerTransform.transform.position.x > this.transform.position.x;
    }
}
