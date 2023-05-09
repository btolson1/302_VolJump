/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Game Manager UI
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    public GameObject platformPrefab;

    [SerializeField]
    public GameObject MainMenu, ScoreScreen, OptionsScreen, _platform, _player;

    [SerializeField]
    public GameObject MK, TB, TREC, SE, SU, NS;
    public GameObject _background, VolumeScreen;
    public int platformCount = 300;

    // When the Play Button is clicked, Platforms are spawned,
    // and the game begins
    public void StartFrame() 
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(1f, 3f);
            spawnPosition.x = Random.Range(-20f, 20f); // .5f, 5f
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Loads Main menu screen with necessary canvas elements activated
    // and not activated
    public void Start() 
    {
        VolumeScreen.SetActive(false);
        MK.SetActive(false);
        TB.SetActive(false);
        TREC.SetActive(false);
        SE.SetActive(false);
        SU.SetActive(false);
        _background.SetActive(false);
        NS.SetActive(true);
        MainMenu.SetActive(true);
        ScoreScreen.SetActive(false);
        OptionsScreen.SetActive(false);
        _platform.SetActive(false);
        _player.SetActive(false);

    }
}
