using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool canMove = true;

    [SerializeField] float maxPos; // 7

    [SerializeField] float moveSpeed; // 15

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    void Move()
    {
        // move player to left and right
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        // restrict movement to boundaries
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
