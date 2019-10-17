﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDir = mousePos - gameObject.transform.position;
        mouseDir.z = 0.0f;
        mouseDir = mouseDir.normalized;
        if (Input.GetMouseButton(0))
        {
            rb2d.AddForce(mouseDir * 10);
        }
    }
}