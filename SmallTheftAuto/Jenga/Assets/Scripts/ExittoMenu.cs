using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExittoMenu : MonoBehaviour
{
    public GameObject MainMenu;
    
    public void CloseButton()
    {
        MainMenu.SetActive(false);
        Time.timeScale = 1;
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
