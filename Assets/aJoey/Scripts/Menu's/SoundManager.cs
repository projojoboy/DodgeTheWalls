using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    private bool soundActive;
    public GameObject SoundButton;

    public Sprite unMute;
    public Sprite Mute;

	// Use this for initialization
	void Start () {
        soundActive = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchSoundMode()
    {
        if(soundActive == true)
        {
            AudioListener.volume = 0;
            soundActive = false;
            SoundButton.GetComponent<Image>().sprite = Mute;
        }
        else
        {
            AudioListener.volume = 1;
            soundActive = true;
            SoundButton.GetComponent<Image>().sprite = unMute;
        }
    }
}
