using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour {

    private Vector2 startPosition;
    private Vector2 newPosition;

    private int speed;
    [SerializeField] private int maxDistance = 1;

    void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
        speed = Random.Range(-3, 3);
    }

    void Update()
    {
        if (speed == 0)
        {
            speed = Random.Range(-3, 3);
        }

        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }
}
