using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public Transform Background1;
    public Transform Background2;

    private bool Whichone = true;

    public Transform cam;

    private float currentHeight = 15;
   
	// Update is called once per frame
	void Update () {
		if(currentHeight < cam.position.y)
        {
            if (Whichone)
            {
                Background1.localPosition = new Vector3(22, Background1.localPosition.y + 30, 10);
            }
            else
            {
                Background2.localPosition = new Vector3(22, Background2.localPosition.y + 30, 10);
            }
            currentHeight += 15;

            Whichone = !Whichone;
        }
        if(currentHeight > cam.position.y + 15)
        {
            if (Whichone)
            {
                Background2.localPosition = new Vector3(22, Background2.localPosition.y - 30, 10);
            }
            else
            {
                Background1.localPosition = new Vector3(22, Background1.localPosition.y - 30, 10);
            }
            currentHeight -= 15;

            Whichone = !Whichone;
        }
	}
}
