using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public Button pauseButton;
    public GameObject Panel;
    public bool panel = false;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = pauseButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        if (pauseButton == true)
        {
            Time.timeScale = 0;
            Panel.SetActive(true);
        }
        
        
    }

   
    

}
