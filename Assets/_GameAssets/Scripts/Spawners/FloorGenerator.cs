using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour
{
    public GameObject[] prefabsFloor;
    public int firstFloor;

    private float z = 2;
    void Start()
    {
        //Validación
        if (firstFloor>=prefabsFloor.Length){
            Debug.LogError("FloorGenerator: El índice es superior al tamaño del array");
            return;
        }
        //Proceso de creación del primer tramo
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, z);
        Quaternion newRotation = Quaternion.Euler(0,GetRandomY(),0);
        Instantiate(prefabsFloor[firstFloor], newPosition, newRotation);
        //Proceso de generación de los siguientes n-tramos
        for(int i=0;i<100;i++){
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
