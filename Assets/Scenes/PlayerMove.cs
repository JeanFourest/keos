using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public int speed;
    public Rigidbody2D player;
    public float hMove;
    public float vMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        hMove = Input.GetAxis("Horizontal");
        vMove = Input.GetAxis("Vertical");

    }

    private void FixedUpdate() {

        player.velocity = new Vector2(hMove * speed, vMove * speed);

    } 
}
