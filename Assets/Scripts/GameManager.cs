using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // we create staic instance of this class
    // because we need to access to this class from everywhere
    public static GameManager instance;

    int score = 0;

    bool gameOver = false;

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
        print(score);
    }
}
