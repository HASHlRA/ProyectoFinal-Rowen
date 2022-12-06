using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        // Repeats the background, the backgroundspeed determines how fast the background repeats
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
