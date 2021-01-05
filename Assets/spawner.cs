using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cam;
    public GameObject[] obstacles;
    public Vector3 spawnValues;
    private float spawnWait;
    public float leastWait;
    public float mostWait;
    public int startWait;
    public bool stop = false;
    int randObs;
    public int obsNumber = 2;
    public float dis;
    void Awake()
    {
        dis = GameObject.Find("warning").GetComponent<warning>().dis;
        StartCoroutine(waitSpawner());
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(leastWait, mostWait);
    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randObs = Random.Range(0, obsNumber);
            if (obstacles[randObs].name == "warning")
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), dis, 0);
                Instantiate(obstacles[randObs], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            }
            if (obstacles[randObs].name == "birdL")
            {
                Vector3 spawnPosition = new Vector3(-spawnValues.x - 1f, Random.Range(-spawnValues.y, spawnValues.y), 0);
                Instantiate(obstacles[randObs], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            }
            if (obstacles[randObs].name == "birdR")
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x + 1f, Random.Range(-spawnValues.y, spawnValues.y), 0);
                Instantiate(obstacles[randObs], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            }
            if (obstacles[randObs].name == "tracer")
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), 0);
                Vector3 euler = new Vector3(0, 0, Random.Range(-90, 90));

                Instantiate(obstacles[randObs], spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.Euler(euler));
            }

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
