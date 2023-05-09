/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
Destroyer of Platforms
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    // Platforms are destroyed as the player rises in y-position
    // This is to prevent the player from being saved from their death 
    // when they fall off a high platform
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);
    }
 }
