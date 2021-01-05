using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cam;
    private GameObject obj;
    public GameObject [] objPreFab;
    public int objNum = 3;
    int randObj;
    public float hailDis = 2f;
    public float dis = 13f;
    public float wait=2f;
    void Awake()
    {
        cam = GameObject.Find("Main Camera").transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, cam.position.y + dis, 0);
        if(wait > 0)
        {
            wait -= Time.deltaTime;

        }
        else
        {
            randObj = Random.Range(0, objNum);
            obj = (GameObject)Instantiate(objPreFab[randObj], new Vector2(transform.position.x, transform.position.y + hailDis), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
