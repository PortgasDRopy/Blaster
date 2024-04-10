using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int movementSpeed = 10;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        Vector2 velo = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.D))
        {
            velo.x += movementSpeed;
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.A))
        {
            velo.x -= movementSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velo.y -= movementSpeed;
        }
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.W))
        {
            velo.y += movementSpeed;
        }
        /*else if (Input.)
        {
            velo = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }*/
        rb.velocity = velo;
    }
}
