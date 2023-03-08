using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offscreen : MonoBehaviour
{

    private int limit = -30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < limit)
        {

            Destroy(gameObject);

        }
        
    }
}
