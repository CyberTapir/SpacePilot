//
// I am committed to being a person of integrity.
// This project is submitted as part of the assessment for Year 9 IST.
// This is all my own work. I have referenced any work used from other
// sources and have not plagiarised the work of others.
// (signed) Callum Bennett
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    //Variables
    public static int score = 0;
    public float speed;
    public static bool gameOver = false;
    public GameObject gameOverPopUp;
    public Text scoreText;
    public Text highScoreText;
    public static int highScore;

    // Start is called before the first frame update
    void Start()
    {
        //Setting gameOver as false so the game runs
        gameOver = false;
        Time.timeScale = 1;
        //Removing the "you died" popup
        gameOverPopUp.SetActive(false);
        //Update the score every second
        InvokeRepeating("incrementScore", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        //Moving the player along the x axis
        float h = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(speed * h, 0);
        transform.Translate(movement * Time.deltaTime, Space.World);
        //This if statement checks if the player is out of frame. If they are, put them back in frame
        if (transform.position.x < -8.7)
        {
            transform.position = new Vector2(-8.7f, -4f);
        } else if (transform.position.x > 8.7)
        {
            //This else if statement checks if the player is out of frame. If they are, put them back in frame
            transform.position = new Vector2(8.7f, -4f);
        }
        //Checking if the player collides with the obstacle
        CheckGameOver();
    }

    void incrementScore()
    {
        //Updating the score each second
        score = score + 1;
    }

    void CheckGameOver()
    {
        if (gameOver)
        {
            //This if statement is checking whether the score is greater than Highscore, and if it is,
            //  setting it as the new highscore
            if (score > PlayerPrefs.GetFloat("HighScore", 0))
            {
                PlayerPrefs.SetFloat("HighScore", score);
            }
            //Setting the text for the game over popup
            Time.timeScale = 0;
            highScoreText.text = "Your high score is: " + PlayerPrefs.GetFloat("HighScore");
            scoreText.text = "Your score was: " + score;

            //Opening the popup
            gameOverPopUp.SetActive(true);
        }
    }
}
