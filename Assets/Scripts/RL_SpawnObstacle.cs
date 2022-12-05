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
        InvokeRepeating("Spawn", timeBetweenSpawn, timeBetweenSpawn);
    }
    

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minX, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
