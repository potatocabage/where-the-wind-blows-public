using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hail : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        Destroy(gameObject, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
