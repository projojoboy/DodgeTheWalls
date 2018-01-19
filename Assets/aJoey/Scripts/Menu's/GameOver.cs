using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private Rigidbody2D rb;
    public bool dead = false;
    public bool isDead;

    public GameObject restartButton;

    public AudioClip deadSound;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        isDead = false;
        restartButton.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall" && isDead == false)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, 250));
            dead = true;
            StartCoroutine(RestartButtonTimer());
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = deadSound;
            audio.Play();
            isDead = true;
        }
    }

    IEnumerator RestartButtonTimer()
    {
        yield return new WaitForSeconds(3);
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
