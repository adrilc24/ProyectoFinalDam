using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] float delaySeconds = 3f;
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
        StartCoroutine(WaitNLoad());     
    }

    IEnumerator WaitNLoad()
    {
        yield return new WaitForSeconds(delaySeconds);
        SceneManager.LoadScene("Game Over");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
