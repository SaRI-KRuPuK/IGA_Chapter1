using UnityEngine;
using UnityEngine.UI;

public class Player1Score : MonoBehaviour
{

    public PlayerControl player1; // skrip
    public Text player1ScoreText;

    // Update is called once per frame
    void Update()
    {
        player1ScoreText.text = player1.Score.ToString();
    }
}
