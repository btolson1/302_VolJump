using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dies : MonoBehaviour
{
    public GameObject _player, endscene;
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
        SceneManager.LoadScene("EndScene");
      //  endscene.SetActive(true);
    }

}
