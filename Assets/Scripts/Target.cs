using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
{
    Debug.Log("Ball hit the floor and has been vanquished...");
    if (collision.gameObject.CompareTag("Ball"))
    {
        Destroy(collision.gameObject);
    }
}
}
