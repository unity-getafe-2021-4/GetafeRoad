using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int score;
    GameManager gameManager;
    private void Start() {
        gameManager = GameManager.Instance;
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name=="Scorer"){
            gameManager.AddScore(score);
            Destroy(other.gameObject);//Destrucción del objeto contra el que hemos hecho trigger
        }
    }
}
