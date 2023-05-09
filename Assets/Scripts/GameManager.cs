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

    public Buttons bm;

    [SerializeField]
    public GameObject platformPrefab;

    [SerializeField]
    public GameObject MainMenu, ScoreScreen, OptionsScreen, _platform, _player;

    [SerializeField]
    public GameObject MK, TB, TREC, SE, SU, NS;
    public GameObject _background, VolumeScreen;
    public int platformCount = 400;

    // When the Play Button is clicked, Platforms are spawned,
    // and the game begins

    public void StartFrame() 
    {
        // Game Increases in difficulty as the player progresses by spreading apart spawns of platforms
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < platformCount; i++)
        {
            if (i < 50) {
                spawnPosition.y += Random.Range(1f, 1.5f);
            }
            else if (i >= 50 && i <= 150) {
                spawnPosition.y += Random.Range(1.5f, 3.5f);
            }
            else if (i >= 150 && i <= 250) {
                spawnPosition.y += Random.Range(2, 4.5f);
            }
            else  {
                spawnPosition.y += Random.Range(3.5f, 6f);
            }
            spawnPosition.x = Random.Range(-20f, 20f); 
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Loads Main menu screen with necessary canvas elements activated
    // and not activated
    public void Start() 
    {
        // Save Background changes throughout each run
        int back = PlayerPrefs.GetInt("back", 0);
        if (back == 0){
            bm.SelectNeyland();
        }
        if (back == 1){
             bm.SelectDrScott();
        }
        if (back == 2) {
            bm.SelectMinKao();
        }
        if (back == 3) {
            bm.SelectStudentUnion();
        }
        if (back == 4){ 
            bm.SelectTorchBearer();
        }
        if (back == 5) {
            bm.SelectTRECS();
        }

        _background.SetActive(false);
        MainMenu.SetActive(true);
        ScoreScreen.SetActive(false);
        OptionsScreen.SetActive(false);
        _platform.SetActive(false);
        _player.SetActive(false);
        VolumeScreen.SetActive(false);

    }
}
