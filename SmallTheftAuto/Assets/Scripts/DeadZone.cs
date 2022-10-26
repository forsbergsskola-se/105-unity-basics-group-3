using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeadZone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("the tower has collapsed, you lose.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
