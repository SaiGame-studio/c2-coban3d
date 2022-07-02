using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    public Transform textGameOver;
    public Transform btnGameOver;

    void Start()
    {
        this.textGameOver = transform.Find("textGameOver");
        this.btnGameOver = transform.Find("btnGameOver");
    }

    void FixedUpdate()
    {
        this.ShowUIGameOver();
    }

    protected virtual void ShowUIGameOver()
    {
        if (GameManager.instance.gameOver)
        {
            this.textGameOver.gameObject.SetActive(true);
            this.btnGameOver.gameObject.SetActive(true);
            return;
        }

        this.textGameOver.gameObject.SetActive(false);
        this.btnGameOver.gameObject.SetActive(false);
    }

    public virtual void GameOver()
    {
        GameManager.instance.Replay();
    }
}
