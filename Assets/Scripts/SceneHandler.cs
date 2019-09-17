using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    [SerializeField] float gameOverLoadDelay = 1f;
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Level 1");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOverScene()
    {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(gameOverLoadDelay);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
