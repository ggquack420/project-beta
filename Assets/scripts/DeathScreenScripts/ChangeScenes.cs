using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour


{
    public void Death()
    {
        SceneManager.LoadScene("death");
    }
    public void main()
    {
        SceneManager.LoadScene("Main_menu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void info()
    {
        SceneManager.LoadScene("info");
    }
    public void levels()
    {
        SceneManager.LoadScene("levels");
    }
}
