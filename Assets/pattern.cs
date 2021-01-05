using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pattern : MonoBehaviour
{
    // Start is called before the first frame update
    public int num = 5;
    int rand;
    Vector3 spawnValues;
    public GameObject shard;
    Vector3 euler;
    void Start()
    {
        rand = Random.Range(0, num);
        spawnValues = GameObject.Find("spawner").GetComponent<spawner>().spawnValues;
        //Debug.Log(spawnValues.x + " " + spawnValues.y + " " + spawnValues.z);    
        Debug.Log("bruh");
        if(rand == 0)
        {
            Vector3 spawnPosition = new Vector3(-spawnValues.x, spawnValues.y, 0);
            euler = new Vector3(0, 0, Mathf.Atan2(-spawnValues.y, spawnValues.x) * Mathf.Rad2Deg + 270f);
            //euler = new Vector3(0, 0, Mathf.Atan(-10f/5.2f));
            Instantiate(shard, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.Euler(euler));
            spawnPosition = new Vector3(spawnValues.x, spawnValues.y, 0);
            euler = new Vector3(0, 0, Mathf.Atan2(-spawnValues.y, -spawnValues.x) * Mathf.Rad2Deg - 90f);
            Instantiate(shard, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.Euler(euler));
        }
        if (rand == 1)
        {

        }
        if (rand == 2)
        {

        }
        if (rand == 3)
        {

        }
        if (rand == 4)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
