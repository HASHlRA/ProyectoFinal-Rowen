using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    
    void Start()
    {
        // Spawns the obstacle and repeats it every determined seconds
        InvokeRepeating("Spawn", timeBetweenSpawn, timeBetweenSpawn);
    }
    

    void Spawn()
    {
        // Chooses a random coordinate to spawn an obstacle
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minX, maxY);

        //Instantiates the obstacle in the determined coords
        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
