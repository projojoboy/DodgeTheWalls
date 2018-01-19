using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float flapForce;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<Jump>().gameStart == true) //Left mouse button or screen touch on android
        {
            flapForce = flapForce += 0.05f;
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, flapForce));
        }
    }
}