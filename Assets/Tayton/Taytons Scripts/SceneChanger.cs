﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }
    public void MainScene()
    {
        SceneManager.LoadScene("Jonah");
    }
}
// Start is called before the first frame update
