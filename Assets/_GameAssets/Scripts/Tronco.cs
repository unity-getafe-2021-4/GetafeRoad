using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tronco : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    private float speed;
    private void Awake()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EndWall")
        {
            Destroy(gameObject);
        }
    }
}
