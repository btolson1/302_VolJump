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
    public GameObject _background;
    public int platformCount = 300;
    // Start is called before the first frame update

    // Update is called once per frame

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

    public void Start() 
    {
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
