using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public Button menuButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = menuButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void TaskOnClick()
    {
        Debug.Log("I've been clicked");
        SceneManager.LoadScene("MainMenu");
    }
}
