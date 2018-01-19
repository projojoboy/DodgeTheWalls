using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    public float flapForce;
    private Rigidbody2D rb;

    public Sprite sprite1;
    public Sprite sprite2;

    public AudioClip jumpSound;

    public bool gameStart;

    private bool sprite1Active = true;

    private bool gravity;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        gravity = false;
        gameStart = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && gameStart == true) //Left mouse button or screen touch on android
        {
            Flap();
        }
	}

    void Flap()
    {
        if (gameObject.GetComponent<GameOver>().dead == false)
        {
            if (gravity == false)
            {
                rb.gravityScale = 1f;
                gravity = true;
            }

            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, flapForce));
            SwapSprites();
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = jumpSound;
            audio.Play();
        }
    }

    void SwapSprites()
    {
        if(sprite1Active == true)
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
            sprite1Active = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
            sprite1Active = true;
        }
    }
}
