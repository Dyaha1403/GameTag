using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ClassLibraryForTagGame;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject winMenuUI;
    public GameObject pauseMenuUI;
    [SerializeField] private Text MoveText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Restart()
    {
        StartScene.LoadingGame();
        string move = "Moves: " + StartScene.level.numMove.ToString();
        MoveText.text = move;
        pauseMenuUI.SetActive(false);
        winMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        if (StartScene.level.isWin)
        {
            return;
        }

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        pauseMenuUI.SetActive(false);
        winMenuUI.SetActive(false);
        GameIsPaused = false;
        Debug.Log("Load");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
