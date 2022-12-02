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
        score += bananavalue;
        text.text = score.ToString();
    }
}
