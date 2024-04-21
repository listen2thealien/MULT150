using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;

    private bool isGameOver = true;
    private float elapsedTime = 0;
    private bool isRunning = false;
    private bool isFinished = false;

    private void StartGame()
    {
        elapsedTime = 0;
        isRunning = true;
        isFinished = false;
    }

    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;

        if (isRunning)
        {
            elapsedTime += Time.deltaTime;

            if (isGameOver)
            {
                isRunning = false;
                isFinished = true;
            }
        }
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 75, Screen.height / 2 - 50, 150, 50);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }

        if (!isRunning && !isGameOver)
        {
            string message;

            if (isFinished)
            {
                message = "Click or Press Enter to Play Again";
            }
            else
            {
                message = "Click or Press Enter to Play";
            }

            Rect startButton = new Rect(Screen.width / 2 - 120, Screen.height / 2 - 15, 240, 30);
            if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
            {
                StartGame();
            }
        }

        if (isFinished)
        {
            float timeBoxHeight = 40 + 36; // Increased the height by 36 (half an inch equals 36 pixels)
            float timeLabelHeight = 30;
            float verticalOffset = 72; // 1 inch equals 72 pixels
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height / 2 - timeBoxHeight - timeLabelHeight - verticalOffset + -2, 130, timeBoxHeight), "Your Time Was");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height / 2 - timeBoxHeight - timeLabelHeight + 8 - verticalOffset + 8, 20, timeLabelHeight), ((int)elapsedTime).ToString());
        }
        else if (isRunning)
        {
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
        }
    }
}