using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    public GameObject windPreFab;
    private GameObject myWind;
    public float xRandom = 5.5f;
    public float yOffSet = 14f;
    public float yRandom = .5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "wind")
        {
            myWind = (GameObject)Instantiate(windPreFab, new Vector2(Random.Range(-xRandom, xRandom), cam.transform.position.y + (yOffSet + Random.Range(-yRandom, yRandom))), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
