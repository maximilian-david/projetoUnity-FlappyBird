using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamecontrol : MonoBehaviour
{
    public static Gamecontrol gameControl;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = 1.5f;

    public Text scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (gameControl == null)
        {
            gameControl = this;
        }else if (gameControl != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScore()
    {
        if (gameOver)
        {
            return;
        }

        score++;
        scoreText.text = "Pontos: " + score.ToString();
    }

    public void BirdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
