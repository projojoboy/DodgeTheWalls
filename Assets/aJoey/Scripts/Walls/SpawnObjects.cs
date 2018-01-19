using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public GameObject WallPrefab;

    public Vector3 center;
    public Vector3 size;

    private Vector3 startPosition;

	// Use this for initialization
	void Start () {
        SpawnFood();
	}
	
	// Update is called once per frame
	void Update () {
        center = transform.position;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "WallSpawner")
        {
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 7, other.transform.position.z);
            SpawnFood();
        }
    }

    public void SpawnFood()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2) + 8);

        Instantiate(WallPrefab, pos, Quaternion.identity);
    }
}
