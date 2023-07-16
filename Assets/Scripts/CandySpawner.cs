using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{

    // range by X where we want to appear our candy
    [SerializeField] float maxX; // 6.5

    public GameObject[] Candies; // list of candies objects

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnCandy();
    }
    

    void SpawnCandy()
    {
        int rand = Random.Range(0, Candies.Length);

        float randomX = Random.Range(-maxX, maxX);

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        Instantiate(Candies[rand], randomPos, transform.rotation);
    }
}
