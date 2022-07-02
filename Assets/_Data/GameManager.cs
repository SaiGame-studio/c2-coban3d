using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;//Singleton
    public bool gameOver = false;

    private void Awake()
    {
        GameManager.instance = this;
    }

    public virtual void GameOver()
    {
        this.gameOver = true;
    }

    public virtual void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
