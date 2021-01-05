using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zap : MonoBehaviour
{
    // Start is called before the first frame update
    public float wait = 1f;
    public GameObject boltPreFab;
    private GameObject myBolt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wait > 0)
        {
            wait -= Time.deltaTime;

        }
        else
        {
            myBolt = (GameObject)Instantiate(boltPreFab, new Vector2(transform.position.x, transform.position.y), transform.rotation);
            Destroy(gameObject);
        }
    }
}
