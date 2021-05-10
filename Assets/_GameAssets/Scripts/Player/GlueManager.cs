using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Glue")){
            transform.SetParent(other.gameObject.transform);
        }
    }
}
