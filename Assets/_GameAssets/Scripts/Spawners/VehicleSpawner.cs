using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject[] vehicles;
    public float minCreationSpeed;
    public float maxCreationSpeed;

    private float speedCreation;//Determina el tiempo entre creaciones

    private int vehicleIndex;//Determina el vehículo a crear
    void Start()
    {
        vehicleIndex = Random.Range(0,vehicles.Length);
        speedCreation = Random.Range(minCreationSpeed, maxCreationSpeed);
        InvokeRepeating("SpawnVehicle", speedCreation, speedCreation);
    }

    private void SpawnVehicle(){
        Instantiate(vehicles[vehicleIndex], transform.position, transform.rotation);
    }
}