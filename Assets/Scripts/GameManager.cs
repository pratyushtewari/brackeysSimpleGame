
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool gameEnded = false;
    public Score score;
    public void EndGame ()
    {
        if (gameEnded != true)
        {
            gameEnded = true;
            Debug.Log("Game Ended");            
            score.UpdateScore("Game Ended Buddy");
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
