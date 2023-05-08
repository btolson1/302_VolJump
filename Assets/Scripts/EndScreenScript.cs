using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int score, highscore;
    public TMP_Text endHighScoreText, endScoreText;

   public void Start() 
    {
        highscore = PlayerPrefs.GetInt("highScore", 0);
        score = PlayerPrefs.GetInt("score", 0);
        endHighScoreText.text = "High Score: " + highscore.ToString();
        endScoreText.text = "Your Score: " + score.ToString();
    }
}
