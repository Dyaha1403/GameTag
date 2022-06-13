using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibraryForTagGame;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class MouseClick : MonoBehaviour
{
    bool moving = false;
    Vector3 startPosition;
    Vector3 endPosition;
    Quaternion startRotation;
    Quaternion endRotation;
    float startTime;
    [SerializeField] private Text MoveText;
    [SerializeField] private GameObject winPanel;
    string move = "0";

    private void OnMouseDown()
    {
        if (!StartScene.level.isWin)
        {
            if (!moving && !PauseMenu.GameIsPaused)
            {
                if (!Physics.Linecast(transform.position, transform.position + Vector3.right))
                {
                    endPosition = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                    endRotation = Quaternion.Euler(270f, 90f, 180f);
                    StartScene.level.Move(Convert.ToInt32(transform.position.x), Convert.ToInt32(transform.position.z), "right");
                    Move();
                    StartScene.level.CheckOnWin();
                }
                else if (!Physics.Linecast(transform.position, transform.position + Vector3.left))
                {
                    endPosition = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                    endRotation = Quaternion.Euler(270f, -90f, 0f);
                    StartScene.level.Move(Convert.ToInt32(transform.position.x), Convert.ToInt32(transform.position.z), "left");
                    Move();
                    StartScene.level.CheckOnWin();
                }
                else if (!Physics.Linecast(transform.position, transform.position + Vector3.forward))
                {
                    endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
                    endRotation = Quaternion.Euler(270f, 0f, 90f);
                    StartScene.level.Move(Convert.ToInt32(transform.position.x), Convert.ToInt32(transform.position.z), "forward");
                    Move();
                    StartScene.level.CheckOnWin();
                }
                else if (!Physics.Linecast(transform.position, transform.position + Vector3.back))
                {
                    endPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
                    endRotation = Quaternion.Euler(-90f, 0f, 90f);
                    StartScene.level.Move(Convert.ToInt32(transform.position.x), Convert.ToInt32(transform.position.z), "back");
                    Move();
                    StartScene.level.CheckOnWin();
                }

                if (StartScene.level.isWin)
                {
                    winPanel.SetActive(true);
                }
            }
        }
    }

    public void Move()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        startTime = Time.time;
        moving = true;
        move = "Moves: " + StartScene.level.numMove.ToString();
        MoveText.text = move;
    }

    void Update()
    {
        if (moving)
        {
            float t = (Time.time - startTime) / 0.25f;

            transform.position = Vector3.Lerp(startPosition, endPosition, t);
            transform.rotation = Quaternion.Lerp(startRotation, endRotation, t);

            if(t >= 1)
            {
                moving = false;
                transform.rotation = startRotation;
            }
        }
    }
}
