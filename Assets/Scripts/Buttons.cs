/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Button Managing Script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public GameObject MainMenu, ScoreScreen, _player, _platform;
    public GameObject OptionsScreen, BackGrounds, VolSlider;
    public GameObject MK, TB, TREC, SE, SU, NS;

    // Play Button Starts the Game
   public void OnButtonPress(){
        MainMenu.SetActive(false);
        ScoreScreen.SetActive(true);
        _player.SetActive(true);
        _platform.SetActive(true);
   }

   // All Main menu buttons Load back original scene
   public void PressMainMenu() {
     SceneManager.LoadScene("Level1");
   }

  // Exit application in player mode and editor mode
   public void Quit() {
     Application.Quit();
   }
   
   // Use Canvas activation to Determine which panels should be
   // shown to the user and which ones should not. This is to 
   // agument the main menu with different paths and options
   public void PressOptions() {
     MainMenu.SetActive(false);
     OptionsScreen.SetActive(true);
   }

   public void PressBackgrounds() {
     OptionsScreen.SetActive(false);
     BackGrounds.SetActive(true);
   }

   public void BackgroundsToMainMenu() {
     BackGrounds.SetActive(false);
     MainMenu.SetActive(true);
   }
   public void OptionsToMainMenu() {
     OptionsScreen.SetActive(false);
     VolSlider.SetActive(false);
     MainMenu.SetActive(true);
     BackGrounds.SetActive(false);
   }

  // Set Backgrounds depending on selected button
  // Must deselect any existing backgrounds working
   public void SelectMinKao() {
     MK.SetActive(true);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(false);
     PlayerPrefs.SetInt("back", 2);
   }
      public void SelectTRECS() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(true);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(false);
     PlayerPrefs.SetInt("back", 5);
   }
      public void SelectDrScott() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(true);
     SU.SetActive(false);
     NS.SetActive(false);
     PlayerPrefs.SetInt("back", 1);
   }
      public void SelectNeyland() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(true);
     PlayerPrefs.SetInt("back", 0);
   }
      public void SelectStudentUnion() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(true);
     NS.SetActive(false);
     PlayerPrefs.SetInt("back", 3);
   }
      public void SelectTorchBearer() {
     MK.SetActive(false);
     TB.SetActive(true);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(false);
     PlayerPrefs.SetInt("back", 4);
   }

  // Load Volume Canvas
   public void PressVolume() {
    OptionsScreen.SetActive(false);
    VolSlider.SetActive(true);
   }

// Load High Score Leaderboard
   public void PressLeaderBoard() {
    SceneManager.LoadScene("HighScores");
   }

}
