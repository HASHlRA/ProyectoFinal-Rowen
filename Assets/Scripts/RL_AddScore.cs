using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RL_AddScore : MonoBehaviour
{
    public static RL_AddScore instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int bananavalue)
    {
        // adds the score when the player touches a banana and displays it
        score += bananavalue;
        text.text = score.ToString();
    }
}
