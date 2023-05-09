/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Test Leaderboard Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
    public TMP_Text text1, text2, text3, text4, text5, text6;

    private List<int> scores = new List<int>(){0, 0, 0, 0, 0, 0};
    private int first, second, third, fourth, fifth, sixth;

    // Using Lists and Arrays to sort High Score Data for the Leaderboard
    // PlayerPrefs saves data across plays, and the lists add, delete, and sort data
    
    public void Start()
    {
        scores[5] = PlayerPrefs.GetInt("first", 0);
        scores[4] = PlayerPrefs.GetInt("second", 0);
        scores[3] = PlayerPrefs.GetInt("third", 0);
        scores[2] = PlayerPrefs.GetInt("fourth", 0);
        scores[1] = PlayerPrefs.GetInt("fifth", 0);
        scores[0] = PlayerPrefs.GetInt("sixth", 0);

        // Check if the Data is in the top 6 best scores
        scores.Sort();
        var scoresArr = scores.ToArray();
        if (PlayerPrefs.GetInt("score") > scoresArr[0]) {
            scores.RemoveAt(0);
            scores.Add(PlayerPrefs.GetInt("score", 0));
        }
        scores.Sort();

        scoresArr = scores.ToArray();

        // Rank scores in descending order by going through backwards
        first = scoresArr[5];
        second = scoresArr[4];
        third = scoresArr[3];
        fourth = scoresArr[2];
        fifth = scoresArr[1];
        sixth = scoresArr[0]; 

        PlayerPrefs.SetInt("first", first);
        PlayerPrefs.SetInt("second", second);
        PlayerPrefs.SetInt("third", third);
        PlayerPrefs.SetInt("fourth", fourth);
        PlayerPrefs.SetInt("fifth", fifth);
        PlayerPrefs.SetInt("sixth", sixth);

        // Print out scores in correct order
        text1.text = first.ToString();
        text2.text = second.ToString();
        text3.text = third.ToString();
        text4.text = fourth.ToString();
        text5.text = fifth.ToString();
        text6.text = sixth.ToString();

    }
}
