using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shard : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed = 30f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * speed);
        Destroy(gameObject, 4f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
