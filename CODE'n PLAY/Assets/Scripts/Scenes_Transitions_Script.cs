using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_Transitions_Script : MonoBehaviour {

    public void play()
    {
        SceneManager.LoadScene("Workshop_Game");
    }
    public void quit()
    {
        Application.Quit();
    }


}
