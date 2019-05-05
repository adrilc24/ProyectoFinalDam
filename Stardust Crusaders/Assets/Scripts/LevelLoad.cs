using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoad : MonoBehaviour
{
   public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Juego");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
