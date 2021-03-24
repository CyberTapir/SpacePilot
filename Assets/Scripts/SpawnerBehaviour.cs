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

        //Setting a random speed for the obstacle
        ObstacleBehaviour obScript = obstacle.GetComponent<ObstacleBehaviour>();
        obScript.speed = Random.Range(2.8f, 22f);

        //Setting a random size for the obstacle
        float size = Random.Range(0.1f, 0.4f);
        obstacle.transform.localScale = new Vector2(size, size);

        //Spawning the obstacle
        Instantiate(obstacle);
    }
}
