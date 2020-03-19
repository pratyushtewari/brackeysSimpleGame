using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text text;
    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameEnded != false)
        {
            return;
        }
        text.text = player.position.z.ToString("0");
    }

    public void UpdateScore(string newText)
    {
        Debug.Log(newText);
        text.text = newText;
    }
}
