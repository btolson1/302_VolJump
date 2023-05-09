/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
SoundScript
*/
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

    void Update()
    {
        // Score is constantly updated by checking the y value of the player
        // each frame
        if (score < ((int)target.transform.position.y)) {
            score = (int)target.transform.position.y;
        }

        // High Score is also updated if it is surpassed during the game
        if (score > PlayerPrefs.GetInt("highScore")) {
            highscore = score;
            PlayerPrefs.SetInt("highScore", highscore);
        }

        // Save the Score and High Score for printing out in the End Panel
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE " + highscore.ToString();
        PlayerPrefs.SetInt("score", score);
    }

}
