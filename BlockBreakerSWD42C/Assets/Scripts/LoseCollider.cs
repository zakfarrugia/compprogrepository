﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D myCollider)
    {
        SceneManager.LoadScene("GameOver");

        print("Game Over");
        print(myCollider.gameObject.name);
    }

    
   

}
