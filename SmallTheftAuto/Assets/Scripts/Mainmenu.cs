using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    public GameObject MainMenu;
    public void openMenu()
    {
        MainMenu.SetActive(true);
        Time.timeScale = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
