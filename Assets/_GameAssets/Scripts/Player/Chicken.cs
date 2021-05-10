using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public Rigidbody rigidBody;
    public AudioSource audioSource;
    public float xForce;
    public float yForce;
    public float zForce;
    [Space(10)]
    [Header("-----Sound Configuration-----")]
    public AudioClip[] jumpSounds;
    [Space(5)]
    public AudioClip scoreSound;
    [Space(5)]
    [Range(0.9f,1)]
    [Tooltip("Pitch mínimo")]
    public float minPitch;
    [Range(1f, 1.1f)]
    public float maxPitch;
    [Header("Prefab explosion")]
    public GameObject prefabExplosion;
    private GameManager gameManager;
    private void Start() {
        gameManager = GameManager.Instance;
    }
    void Update()
    {
        if (Mathf.Abs(GetComponent<Rigidbody>().velocity.y)>0.01f) return;

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            Jump(0, 1, 1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0,90,0);
            Jump(1, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0,-90,0);
            Jump(-1, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0,-180,0);
            Jump(0, 1, -1);
        }
    }

    void Jump(float x, float y, float z)
    {
        transform.SetParent(null);
        //Modificaci�n (pseudo)aleatoria del pitch
        audioSource.pitch = Random.Range(minPitch, maxPitch);
        //Reproduzca el sonido del salto
        audioSource.PlayOneShot(jumpSounds[Random.Range(0,jumpSounds.Length)]);
        //Agregar la fuerza
        Vector3 vectorSalto = new Vector3(
            x * xForce,
            y * yForce,
            z * zForce);
        //rigidBody.AddRelativeForce(vectorSalto);
        rigidBody.AddForce(vectorSalto);
    }

    public void Kill(){
        Instantiate(prefabExplosion, transform.position, transform.rotation);
        gameManager.StartGameOver();
        Destroy(gameObject);
    }
}