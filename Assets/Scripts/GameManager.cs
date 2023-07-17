using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // we create staic instance of this class
    // because we need to access to this class from everywhere
    public static GameManager instance;

    // this will be our LivesPanel
    public GameObject livesHolder;

    // assign here our GameOverPanel in Inspector
    public GameObject gameOverPanel;

    int score = 0;

    int lives = 3;

    bool gameOver = false;

    public TextMeshProUGUI scoreText;

    private void Awake() 
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {

        // if gameOver is not happen
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }

    }

    public void DecreaseLife()
    {
        if (lives > 0)
        {
            lives--;
            print(lives);

            // get child life from panel and dissapear when this function is called
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if (lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }

    public void GameOver()
    {
        // we stop our coroutine to drop our candies
        CandySpawner.instance.StopSpawningCandies();

        // we stop moving player
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
        print("GameOver");
    }

}
