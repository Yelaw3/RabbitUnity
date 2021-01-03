using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false); //Rendre inactif le menu de pause au lancement du jeu
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //Quand on presse Échap, le jeu est mis en pause, et si le jeu est déjà en pause, on reprend la partie.
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame() //Quand jeu en pause : le temps est arrêté & le menu pause est actif
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame() //Quand le jeu reprend : le temps s'écoule normalement & le menu pause est inactif
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu() //Charger la scène du Menu principal & le temps s'écoule normalement
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame() //Quitter le jeu
    {
        Application.Quit();
    }
}