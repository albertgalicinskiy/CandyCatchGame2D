using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    // range by X where we want to appear our candy
    [SerializeField] float maxX; // 6.5

    [SerializeField] float spawnInterval; // 1

    public GameObject[] Candies; // list of candies objects


    // we create an instance of this whole class using static variable
    public static CandySpawner instance;

    // we assign value for the instance static variable
    private void Awake() {
        if (instance == null)
        {
            // means value of instance variable is the same class we are which in
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void SpawnCandy()
    {
        int rand = Random.Range(0, Candies.Length);

        float randomX = Random.Range(-maxX, maxX);

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        Instantiate(Candies[rand], randomPos, transform.rotation);
    }


    // make Repeatedly spawning candies
    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }

}
