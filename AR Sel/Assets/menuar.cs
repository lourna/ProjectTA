using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu1 : MonoBehaviour {

    public void GoToMainMenu()
    {
        Application.LoadLevel("main_menu");
    }

    public void GoToScene()
    {
        Application.LoadLevel("scene1");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

}
