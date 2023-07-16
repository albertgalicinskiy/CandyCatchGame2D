using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    [SerializeField] float maxX; // range by X where we want to appear our candy

    public GameObject[] Candies; // list of candies objects

    // Start is called before the first frame update
    void Start()
    {
        SpawnCandy(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void SpawnCandy()
    {
        int rand = Random.Range(0, Candies.Length);

        Instantiate(Candies[rand], transform.position, transform.rotation);
    }
}
