using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RL_Obstacle : MonoBehaviour
{
    private GameObject player;
    public static RL_Obstacle Instance;

    // Start is called before the first frame update
    void Start()
    {
        // gets the player
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void sceneToMoveTo()
    {
        // gets the game over scene
        SceneManager.LoadScene("RL_GameOver");
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the obstacle collides with a game object with the tag "border", it will be destroyed
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        // if the obstacle touches a game object with the player tag, the playyer will be destroyed and the scene will change
        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
            RL_Obstacle.Instance.sceneToMoveTo();
        }
    }
}
