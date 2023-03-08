using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjoMove : MonoBehaviour
{

    public int speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
        transform.Translate(Vector2.left * Time.deltaTime * speed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
