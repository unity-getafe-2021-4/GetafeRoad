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
        //Proceso de creación
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, z);
        Instantiate(prefabsFloor[firstFloor], newPosition, transform.rotation);
        for(int i=0;i<100;i++){
            z = z + 2;
            newPosition = new Vector3(transform.position.x, transform.position.y, z);
            int floorRandomIndex = Random.Range(0,prefabsFloor.Length);
            Instantiate(prefabsFloor[floorRandomIndex], newPosition, transform.rotation);
        }
    }
   
}
