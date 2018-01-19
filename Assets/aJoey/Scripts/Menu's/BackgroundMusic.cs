using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChooseBackgroundMusic(int musicNumber)
    {
        if(musicNumber == 1)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
            audio.clip = music1;
            audio.Play();
        }
        else if(musicNumber == 2)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
            audio.clip = music2;
            audio.Play();
        }
        else if(musicNumber == 3)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
            audio.clip = music3;
            audio.Play();
        }
    }
}
