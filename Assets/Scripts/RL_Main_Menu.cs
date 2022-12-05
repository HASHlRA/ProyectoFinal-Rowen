using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RL_Main_Menu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("RL_Main_Scene");
    }
}
