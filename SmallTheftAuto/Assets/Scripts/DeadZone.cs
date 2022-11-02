using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnCollisionEnter(Collision Lose) {
        Debug.Log("Tower collapsed. You Lose");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }  

}
