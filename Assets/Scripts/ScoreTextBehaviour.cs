using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextBehaviour : MonoBehaviour
{
    //Variable to update the score
    public Text textComponent;


    // Update is called once per frame
    void Update()
    {
        //Updating the score in real time
        textComponent.text = "Score: " + PlayerBehaviour.score.ToString();
    }
}