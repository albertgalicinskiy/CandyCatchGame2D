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

    int score = 0;

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
        score++;
        scoreText.text = score.ToString();
        print(score);
    }
}
