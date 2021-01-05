using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilted : MonoBehaviour
{
    // Start is called before the first frame update
    

    Rigidbody2D rb;
    public float speed = 20f;
    float tilt;
    public float min = 1f;
    public float screen = 7.5f;
    public float r = 50f;
    public float rspeed = 50f;
    public float lim = 60f;
    public float g = 1f;
    bool open = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tilt = Input.acceleration.x * speed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -screen, screen), transform.position.y);
        
    }
    void FixedUpdate()
    {
        if (tilt > min||tilt < -min)
        {
            if (tilt < lim && tilt > -lim)
            {
                rb.velocity = new Vector2(tilt, rb.velocity.y);
            }
            else if(tilt < -lim)
            {
                rb.velocity = new Vector2(-lim, rb.velocity.y);
            }
            else if(tilt > lim)
            {
                rb.velocity = new Vector2(lim, rb.velocity.y);
            }
            float angle = Mathf.Acos(tilt/r) * Mathf.Rad2Deg - 90;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rspeed * Time.deltaTime);
        }

        if (Input.touchCount > 0)
        {
            rb.gravityScale = g * 5;
            open = false;
        }
        else
        {
            rb.gravityScale = g;
            open = true;
        }
        if (Input.GetKey("space"))
        {
            rb.velocity = new Vector2(0, 10f);
        }
    }
}
