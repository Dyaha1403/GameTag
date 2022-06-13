using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main : MonoBehaviour
{
    public void LoadLevel_1()
    {
        SceneManager.LoadScene("Level_3x3");
    }

    public void LoadLevel_2()
    {
        SceneManager.LoadScene("Level_4x4");
    }
    public void LoadLevel_3()
    {
        SceneManager.LoadScene("Level_5x5");
    }
    public void LoadLevel_4()
    {
        SceneManager.LoadScene("Level_6x6");
    }
    public void LoadLevel_5()
    {
        SceneManager.LoadScene("Level_7x7");
    }
    public void LoadLevel_6()
    {
        SceneManager.LoadScene("Level_8x8");
    }

    public void LoadLevel_7()
    {
        SceneManager.LoadScene("Level_9x9");
    }
    public void LoadLevel_8()
    {
        SceneManager.LoadScene("Level_10x10");
    }

    public void LoadLevel_9()
    {
        SceneManager.LoadScene("Level_11x11");
    }

    public void LoadLevel_10()
    {
        SceneManager.LoadScene("Level_12x12");
    }

    public void LoadLevel_11()
    {
        SceneManager.LoadScene("Level_13x13");
    }

    public void LoadLevel_12()
    {
        SceneManager.LoadScene("Level_14x14");
    }

    public void LoadLevel_13()
    {
        SceneManager.LoadScene("Level_15x15");
    }

    public void LoadLevel_14()
    {
        SceneManager.LoadScene("Level_16x16");
    }
    public void LoadLevel_15()
    {
        SceneManager.LoadScene("Level_17x17");
    }

    public void LoadLevel_16()
    {
        SceneManager.LoadScene("Level_18x18");
    }

    public void LoadLevel_17()
    {
        SceneManager.LoadScene("Level_19x19");
    }

    public void LoadLevel_18()
    {
        SceneManager.LoadScene("Level_20x20");
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

}
