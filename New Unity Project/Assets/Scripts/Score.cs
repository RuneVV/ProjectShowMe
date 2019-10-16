using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    public int score;
    public int UpdateScore;
    Text text;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
