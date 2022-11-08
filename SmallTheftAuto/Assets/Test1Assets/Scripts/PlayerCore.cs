using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    public GameObject player;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //Save Game
        {
            Vector3 playerPosition = player.transform.position;
            PlayerPrefs.SetFloat("playerPositionX", playerPosition.x);
            PlayerPrefs.SetFloat("playerPositionY", playerPosition.y);
            PlayerPrefs.SetFloat("playerPositionZ", playerPosition.z);
            PlayerPrefs.Save();
            Debug.Log("playerPosition" + playerPosition);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            float playerPositionX = PlayerPrefs.GetFloat("playerPositionX");
            float playerPositionY = PlayerPrefs.GetFloat("playerPositionY");
            float playerPositionZ = PlayerPrefs.GetFloat("playerPositionZ");
            Vector3 playerPosition = new Vector3(playerPositionX, playerPositionY, playerPositionZ);
            Debug.Log(playerPosition);

            player.transform.position = playerPosition;
        }
    }
}
