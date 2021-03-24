using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Moving the asteroid down the frame
        transform.Translate(speed * -transform.up * Time.deltaTime, transform);
        if (transform.position.y < -6)
        {
            //Destroying the asteroid if it is out of the frame
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the asteroid collides with the player, end the game
        Debug.Log("Collision with player");
        Destroy(gameObject);
        PlayerBehaviour.gameOver = true;
    }
}
