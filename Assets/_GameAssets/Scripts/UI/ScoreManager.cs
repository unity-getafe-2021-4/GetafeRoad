using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Incluir la librería de UI

public class ScoreManager : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = 
            gameManager.GetScore().ToString();
    }
}