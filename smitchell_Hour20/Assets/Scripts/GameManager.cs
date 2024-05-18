using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextureScroller ground;
    public float gameTime = 10f;

    private float totalTimeElapsed = 0f;
    private bool isGameOver = false;

    private void Update()
    {
        if (isGameOver)
            return;

        totalTimeElapsed += Time.deltaTime;
        gameTime -= Time.deltaTime;

        if (gameTime <= 0)
            isGameOver = true;
    }

    public void AdjustTime(float amount)
    {
        gameTime += amount;
        if (amount < 0)
            SlowWorldDown();
    }

    private void SlowWorldDown()
    {
        // Cancel any invokes to speed the world up
        // Then slow the world down for 1 second
        CancelInvoke(nameof(SpeedWorldUp));
        Time.timeScale = 0.5f;
        Invoke(nameof(SpeedWorldUp), 1f);
    }

    private void SpeedWorldUp()
    {
        Time.timeScale = 1f;
    }

    private void OnGUI()
    {
        if (!isGameOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            GUI.Box(boxRect, "Time Remaining");

            Rect labelRect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
            GUI.Label(labelRect, ((int)gameTime).ToString());
        }
        else
        {
            Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
            GUI.Box(boxRect, "Game Over");

            Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
            GUI.Label(labelRect, "Total Time: " + ((int)totalTimeElapsed).ToString());

            Time.timeScale = 0f;
        }
    }
}