using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    private float ScreenHeight;
    Vector3 high;
    Vector3 tempPos;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        ScreenHeight = Screen.height;
        Debug.Log("bruh");
        Debug.Log(ScreenHeight);
    }

    // Update is called once per frame
    void Update()
    {
        high = cam.WorldToScreenPoint(player.position);
    }
    void FixedUpdate()
    {
        if (high.y > ScreenHeight / 2) {
            tempPos = transform.position;
            tempPos.y = player.position.y;
            tempPos.z = -10f;
            transform.position = tempPos;
            Debug.Log("higher");
        }
    }
}
