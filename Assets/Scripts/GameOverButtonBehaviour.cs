using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Loading the method when the button is clicked
        Button btn1 = gameObject.GetComponent<Button>();
        btn1.onClick.AddListener(onClickMethod);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClickMethod()
    {
        //Loading the splashscreen when the button has been clicked
        SceneManager.LoadScene("splash");
    }
}
