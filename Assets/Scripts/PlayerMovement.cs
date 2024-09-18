using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    private Vector2 direction;
    [SerializeField] float speed = 10f;
    public static event Action <Vector2> directionEvent;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if(direction!=Vector2.zero)
        {
            directionEvent?.Invoke(direction);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }
}
