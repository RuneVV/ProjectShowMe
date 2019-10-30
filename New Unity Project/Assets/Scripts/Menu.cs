using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;

    public GameObject arrow3;
    public GameObject arrow4;

    public void StartGame()
    {
        arrow1.SetActive(true);
        arrow2.SetActive(true);


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        arrow3.SetActive(true);
        arrow4.SetActive(true);
        Debug.Log("Quit!!");
        Application.Quit();
    }

}
