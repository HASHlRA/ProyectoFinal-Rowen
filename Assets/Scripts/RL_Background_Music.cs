using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_Background_Music : MonoBehaviour
{
    private static RL_Background_Music backgroundMusic;
    

    void Awake()
    {
        // sets the background music
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
