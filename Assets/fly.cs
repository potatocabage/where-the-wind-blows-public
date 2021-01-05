using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed = 30f;
    public float height = 10f;
    public float wait = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, rb.velocity.y);
        StartCoroutine(wobble());
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.up * height);
    }
    IEnumerator wobble()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(wait);
            rb.velocity = new Vector2(speed, 0f);
            height = -height;
            //height = -2 * height;
            //yield return new WaitForSeconds(wait);
            //height = -.5f * height;
        }
    }
}
