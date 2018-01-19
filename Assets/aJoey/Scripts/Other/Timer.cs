using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float score = 0.0f;

    public Text currentTime;
    public Text HighestTime;

    private void Update()
    {
        if (GameObject.Find("Player").GetComponent<Jump>().gameStart && !GameObject.Find("Player").GetComponent<GameOver>().isDead)
        {
            StartTimer();
        }
        currentTime.text = "Current time: " + ((int)score).ToString();

        HighestTime.text = "Highest time: " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();

        if (GameObject.Find("Player").GetComponent<GameOver>().isDead)
        {
            OnDeath();
        }
    }

    public void StartTimer()
    {
        score += Time.deltaTime;
    }

    public void OnDeath()
    {
        if (PlayerPrefs.GetFloat("Highscore") < score)
            PlayerPrefs.SetFloat("Highscore", score);
    }
}