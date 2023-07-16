using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // call automatically when candy collide with the any gameobject
    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            // Increment Score
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }

        // Remove Candy when to goes down and doesn't touch Player
        else if (collider.gameObject.tag == "Boundary")
        {
            // Decrease Lives
            Destroy(gameObject);
        }
    }
}
