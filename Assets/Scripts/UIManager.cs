using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameOverPanel;
    public GameObject endScreenPanel;

    public static UIManager instance;
    void Awake()
    {
        instance = this;
        Time.timeScale = 1.24f;
    }

    private void Update()
    {
        if(gameOverPanel.activeSelf)
        {
            if(Input.GetKey(KeyCode.Return))
            {
                
                SceneManager.LoadScene(1);
               
            }

            if(Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }

        if (endScreenPanel.activeSelf)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
