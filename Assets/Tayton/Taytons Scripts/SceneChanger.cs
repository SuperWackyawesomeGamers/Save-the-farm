using System.Collections;
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
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void deathscene()
    {
        SceneManager.LoadScene("Death scene");
    }
    public void deathscene2()
    {
        SceneManager.LoadScene("2 death scene");
    }
    public void finalbattle()
    {
        SceneManager.LoadScene("final battle");
    }
}
// Start is called before the first frame update
