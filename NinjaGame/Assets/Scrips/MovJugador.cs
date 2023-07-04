using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    public float velocidad;
    public Vector3 moverse;
    public Rigidbody2D RB;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float MovHorizontal = Input.GetAxisRaw("Horizontal");
        float MovVertical = Input.GetAxisRaw("Vertical");

        moverse = new Vector3(MovHorizontal, MovVertical, 0);
        moverse = moverse*velocidad*Time.deltaTime;
        transform.position += moverse;
    }
}
