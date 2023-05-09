/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Death Box
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dies : MonoBehaviour
{
    public GameObject _player, endscene;

    // If the player hits the created death box, load the End Panel
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
        SceneManager.LoadScene("EndScene");
    }
}
