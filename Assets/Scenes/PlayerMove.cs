using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    bool facingRight = true;
    private int speed = 5;
    public Rigidbody2D player;
    public float hMove;
    public float vMove;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        hMove = Input.GetAxis("Horizontal");
        vMove = Input.GetAxis("Vertical");

        if (hMove > 0 && !facingRight)
        {

            Flip();

        }
        else if (hMove < 0 && facingRight)
        {

            Flip();

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }

    }

    private void FixedUpdate() {

        player.velocity = new Vector2(hMove * speed, vMove * speed);

    }

    private void Flip()
    {

        facingRight = !facingRight;
        Vector2 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;

    }


}
