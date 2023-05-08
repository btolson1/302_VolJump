using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public GameObject MainMenu, ScoreScreen, _player, _platform;
    public GameObject OptionsScreen, BackGrounds;
    public GameObject MK, TB, TREC, SE, SU, NS;
   public void OnButtonPress(){
        MainMenu.SetActive(false);
        ScoreScreen.SetActive(true);
        _player.SetActive(true);
        _platform.SetActive(true);
   }
   public void PressMainMenu() {
     SceneManager.LoadScene("Level1");
   }

   public void Quit() {
     Application.Quit();
     UnityEditor.EditorApplication.isPlaying = false;
   }
   
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
     MainMenu.SetActive(true);
   }

   public void SelectMinKao() {
     MK.SetActive(true);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(false);
   }
      public void SelectTRECS() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(true);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(false);
   }
      public void SelectDrScott() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(true);
     SU.SetActive(false);
     NS.SetActive(false);
   }
      public void SelectNeyland() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(true);
   }
      public void SelectStudentUnion() {
     MK.SetActive(false);
     TB.SetActive(false);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(true);
     NS.SetActive(false);
   }
      public void SelectTorchBearer() {
     MK.SetActive(false);
     TB.SetActive(true);
     TREC.SetActive(false);
     SE.SetActive(false);
     SU.SetActive(false);
     NS.SetActive(false);
   }

}
