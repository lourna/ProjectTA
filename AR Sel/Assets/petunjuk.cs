using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petunjuk : MonoBehaviour {

    public void GoToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void GoToARCamera()
    {
        Application.LoadLevel("petunjuk");
    }

    public void ExitApplication()
    {
        Application.Quit();
    }

}
