using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RL_Game_Over : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("RL_Main_Scene");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("RL_Main_Menu");
    }
}
