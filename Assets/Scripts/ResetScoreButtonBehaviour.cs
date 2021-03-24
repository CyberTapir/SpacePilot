//The purpose of this file is to reset the score when teh button is pressed

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScoreButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //When the button is clicked, run the method taskOnClick
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(taskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void taskOnClick()
    {
        //Set the HighScore to 0
        PlayerPrefs.SetFloat("HighScore", 0f);
    }
}
