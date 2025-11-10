using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;
    private float elapsedTime = 0;
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = (blue.isSolved && green.isSolved && red.isSolved && orange.isSolved);
        if (isGameOver == false){
            elapsedTime = elapsedTime + Time.deltaTime;
        }

    }
    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label (rect2, "Good Job!");
            GUI.Box(new Rect(10, 10, 200, 25), "Your time was " + (int)elapsedTime + " seconds.");
            Rect Restart = new Rect(Screen.width / 2 - 100, Screen.height / 2 + 25, 200, 50);
            if (GUI.Button(Restart, "Replay? Press Enter!") || Input.GetKeyDown(KeyCode.Return))
            {
                StartGame ();
            }
        }
    }
    private void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}