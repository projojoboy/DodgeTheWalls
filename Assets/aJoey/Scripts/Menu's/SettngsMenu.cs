using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettngsMenu : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject settingMenu;
    public GameObject settingButton;

    // Use this for initialization
    void Start () {
        settingButton.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player").GetComponent<Jump>().gameStart)
        {
            settingMenu.SetActive(false);
            settingButton.SetActive(false);
        }
    }

    public void ShowSettingMenu(int menu)
    {
        if(menu == 1)
        {
            mainMenu.SetActive(true);
            settingMenu.SetActive(false);
        }
        else if(menu == 2)
        {
            mainMenu.SetActive(false);
            settingMenu.SetActive(true);
        }
    }
}
