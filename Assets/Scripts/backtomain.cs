using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backtomain : MonoBehaviour
{
    public Button menu;
    void Start()
    {
        menu.onClick.AddListener(Menu);
    }

    void Menu()
    {
        SceneManager.LoadScene("menu");
    }

  
}
