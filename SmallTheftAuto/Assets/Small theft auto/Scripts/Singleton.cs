using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton _instance;

    public static Singleton Instance { get; private set; }
 
    /*public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject singleton = new GameObject();
                singleton.name = "Singleton";
                _instance = singleton.AddComponent<Singleton>();
                DontDestroyOnLoad(singleton);
            }

            return _instance;
        }
    }*/

    private static PlayerMovement playerMovement;
    public GameObject player;
    private void Awake()
    {
        Instance = this;
        playerMovement = FindObjectOfType<PlayerMovement>(true);
        player = playerMovement.gameObject;
    }

    
}
