using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RL_Game_Over : MonoBehaviour
{
    public void RestartButton()
    {
        // the restart button will lead to the game again
        SceneManager.LoadScene("RL_Main_Scene");
    }

    public void ExitButton()
    {
        // the exit button will lead to the main menu
        SceneManager.LoadScene("RL_Main_Menu");
    }
}
