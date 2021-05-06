using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject startButton;

    [SerializeField]
    private int score;
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }
    public int GetScore(){
        return score;
    }
    public void AddScore(int scoreToAdd){
        score = score + scoreToAdd;
    }
    public void StartGameOver(){
        startButton.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();//TODO MEJORAR
    }
}