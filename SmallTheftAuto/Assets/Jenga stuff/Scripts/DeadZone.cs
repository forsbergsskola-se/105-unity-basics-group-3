using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        StartCoroutine(Lose());
    }

    IEnumerator Lose()
    {
        Debug.Log("The tower collapsed. You lose.");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
