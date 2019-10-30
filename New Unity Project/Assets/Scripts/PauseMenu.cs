using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;

    public GameObject arrow3;
    public GameObject arrow4;

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUi;

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (GameIsPaused)
        //    {
        //        Resume();
        //    }
        //    else
        //    {
        //        Pause();
        //    }
        //}
    }

    public void Resume()
    {
        arrow1.SetActive(true);
        arrow2.SetActive(true);
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        arrow1.SetActive(false);
        arrow2.SetActive(false);
    }

    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        arrow3.SetActive(true);
        arrow4.SetActive(true);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        arrow3.SetActive(false);
        arrow4.SetActive(false);
    }

  
}
