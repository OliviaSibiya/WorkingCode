using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = quitButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void TaskOnClick()
    {
        Debug.Log("I've been clicked");
        Application.Quit();
    }
}
