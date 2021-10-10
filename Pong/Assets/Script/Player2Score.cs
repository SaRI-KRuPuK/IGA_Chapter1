using UnityEngine;
using UnityEngine.UI;

public class Player2Score : MonoBehaviour
{

    public PlayerControl player2; // skrip
    public Text player2ScoreText;

    // Update is called once per frame
    void Update()
    {
        player2ScoreText.text = player2.Score.ToString();
    }
}
