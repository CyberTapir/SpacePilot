using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        //Spawning the Obstacle at regular intervals
        InvokeRepeating("createObstacle", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createObstacle()
    {
        //Creating an obstacle at a random x position
        obstacle.transform.position = new Vector2(Random.Range(-9f, 9f), transform.position.y);

        //setting the obstacle speed depending on the level
        ObstacleBehaviour obScript = obstacle.GetComponent<ObstacleBehaviour>();

        //Depending on the level, set a speed for the obstacle
        if (PlayerBehaviour.score > 0)
        {
            obScript.speed = Random.Range(2.8f, 13f);
        } else if (PlayerBehaviour.score > 20)
        {
            obScript.speed = Random.Range(3f, 16f);
        }
        
        //Setting a random size for the obstacle
        float size = Random.Range(0.1f, 0.4f);
        obstacle.transform.localScale = new Vector2(size, size);

        //Spawning the obstacle
        Instantiate(obstacle);
    }
}
