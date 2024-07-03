using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenu;
    [SerializeField]
    private GameObject HTPMenu;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HowToPlay()
    {
        MainMenu.SetActive(false);
        HTPMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("GAME OVER");
    }

    public void Back()
    {
        MainMenu.SetActive(true);
        HTPMenu.SetActive(false);
    }
}
