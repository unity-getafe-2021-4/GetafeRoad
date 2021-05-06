using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour
{
    public GameObject[] prefabsFloor;
    [Range(10,1000)]
    public int floorNumber;
    private float z = 0;
    void Start()
    {
        //Proceso de creación del primer tramo
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, z);
        Quaternion newRotation = Quaternion.Euler(0,GetRandomY(),0);
        //Proceso de generación de los siguientes n-tramos
        for(int i=0;i<floorNumber;i++){
            z = z + 2;
            newPosition = new Vector3(transform.position.x, transform.position.y, z);
            int floorRandomIndex = Random.Range(0,prefabsFloor.Length);
            newRotation = Quaternion.Euler(0,GetRandomY(),0);
            Instantiate(prefabsFloor[floorRandomIndex], newPosition, newRotation);
        }
    }

    float GetRandomY(){
        float yRotation = 0;
        float seed = Random.Range(0,100);
        if (seed>50) {
            yRotation = 180;
        }
        return yRotation;
    }
}
