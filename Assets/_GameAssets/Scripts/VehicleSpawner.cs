using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject[] vehicles;
    public float minCreationSpeed;
    public float maxCreationSpeed;

    private float speedCreation;
    void Start()
    {
        speedCreation = Random.Range(minCreationSpeed, maxCreationSpeed);
        InvokeRepeating("SpawnVehicle",speedCreation, speedCreation);
    }

    private void SpawnVehicle(){
        Instantiate(vehicles[Random.Range(0,vehicles.Length)], transform.position, transform.rotation);
    }
}
