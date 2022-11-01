using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject menuButton;
    public GameObject menu;
    private MenuStates _menuState = MenuStates.Closed;

    private void Start()
    {
        if (menu != null && menuButton != null)
        {
            CloseMenu();
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("MenuInput"))
        {
            if (_menuState == MenuStates.Closed)
            {
                OpenMenu();
                Debug.Log("Open menu");
            }
            else
            {
                CloseMenu();
                Debug.Log("Close menu");
            }
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SanAndreas");
    }

    public void OpenMenu()
    {
        menu.SetActive(true);
        menuButton.SetActive(false);
        _menuState = MenuStates.Open;
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
        menuButton.SetActive(true);
        _menuState = MenuStates.Closed;
    }

    
}
     enum MenuStates
     {
         Closed,
         Open
     }
