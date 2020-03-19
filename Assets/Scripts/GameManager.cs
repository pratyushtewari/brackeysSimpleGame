
using UnityEngine;

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
}
