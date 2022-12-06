using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_banana : MonoBehaviour
{
    public int bananavalue = 1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if the player touches the banana the score will be +1
        if (other.gameObject.CompareTag("Player"))
        {
            RL_AddScore.instance.ChangeScore(bananavalue);
        }
    }
}
