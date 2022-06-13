using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    public GameObject BGMusic;
    private AudioSource audioSrc;
    public GameObject[] objs1;

    void Awake()
    {
        objs1 = GameObject.FindGameObjectsWithTag("Sound");

        if (objs1.Length == 0)
        {
            BGMusic = Instantiate(BGMusic);
            BGMusic.name = "BGMusic";
            DontDestroyOnLoad(BGMusic.gameObject);
        }
        else
        {
            BGMusic = GameObject.Find("BGMusic"); 
        }
    }
    void Start()
    {
        audioSrc = BGMusic.GetComponent<AudioSource>();
    }
}