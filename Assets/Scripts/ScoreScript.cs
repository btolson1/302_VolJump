using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    public TMP_Text endHighScoreText, endScoreText;
    public Transform target;

    int score = 0;
    int highscore = 0;
    // Start is called before the first frame update
    public void StartFrame2()
    {
        highscore = PlayerPrefs.GetInt("highScore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (score < ((int)target.transform.position.y)) {
            score = (int)target.transform.position.y;
        }

        if (score > PlayerPrefs.GetInt("highScore")) {
            highscore = score;
            PlayerPrefs.SetInt("highScore", highscore);
        }
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE " + highscore.ToString();
        PlayerPrefs.SetInt("score", score);
    }

}
