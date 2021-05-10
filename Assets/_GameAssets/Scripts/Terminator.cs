using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponentInParent<Chicken>().Kill();
        }
    }
}
