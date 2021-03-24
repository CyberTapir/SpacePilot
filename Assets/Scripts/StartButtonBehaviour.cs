using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonBehaviour : MonoBehaviour
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
        //Set the score to 0 and start the game by loading the scene
        PlayerBehaviour.score = 0;
        SceneManager.LoadScene("s1assign1");
    }
}
