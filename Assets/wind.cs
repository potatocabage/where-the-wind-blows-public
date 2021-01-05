using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float power = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D hit)
    {
        if (hit.tag == "wind")
        {
            rb.AddForce(transform.up * power);
        }
    }
}
