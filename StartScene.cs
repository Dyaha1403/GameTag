using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClassLibraryForTagGame;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    [SerializeField] private int n;
    public static Level level = new Level(3);
   
    void Start()
    {
        level.size = n;
        LoadingGame();
    }

    public static void LoadingGame()
    {
        GameObject GObject = null;
    
        level.LoadPlayingField();
    
        for (int i = 0; i < level.size; i++)
        {
            for (int j = 0; j < level.size; j++)
            {
    
                if (level.playingField[i, j] == 0)
                {
                    continue;
                }
                GObject = GameObject.FindGameObjectWithTag(level.playingField[i, j].ToString());
                GObject.transform.position = new Vector3(i, 0, j);
            }
        }
    }
}
