using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenTerminator : MonoBehaviour
{
    private void OnBecameInvisible() {
        GetComponentInParent<Chicken>().Kill();       
    }
}
