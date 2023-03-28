using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class ruchKulki : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
      rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 vtmp = new Vector2(Input.GetAxis("Horizontal"),0);
        rb.AddForce(vtmp * Time.deltaTime * 500);
        if (Input.GetButton("Jump") && rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * 25);
        }
      }
    }