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

    void Update()
    {
        if (Mathf.Abs(GetComponent<Rigidbody>().velocity.y)>0) return;

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            Jump(0, 1, 1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Jump(1, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            Jump(-1, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Jump(0, 1, -1);
        }
    }

    void Jump(float x, float y, float z)
    {
        //Modificaci�n (pseudo)aleatoria del pitch
        audioSource.pitch = Random.Range(minPitch, maxPitch);
        //Reproduzca el sonido del salto
        audioSource.PlayOneShot(jumpSounds[Random.Range(0,jumpSounds.Length)]);
        //Agregar la fuerza
        Vector3 vectorSalto = new Vector3(
            x * xForce,
            y * yForce,
            z * zForce);
        rigidBody.AddRelativeForce(vectorSalto);
    }
}
