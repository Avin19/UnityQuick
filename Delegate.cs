public delegate void GameOverDelegate();

public event GameOverDelegate OnGameOver;

void EndGame()
{
    if (OnGameOver != null)
    {
        OnGameOver(); // Trigger the event
    }
}