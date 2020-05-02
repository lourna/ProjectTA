using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

    public void GoToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void GoToPetunjuk()
    {
        Application.LoadLevel("petunjuk");
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
