using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_CameraMovement : MonoBehaviour
{
    public float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        // Moves the camera constantly in the x direction, the camera speed determines how fast the camera goes
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
