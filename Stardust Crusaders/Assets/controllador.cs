﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 12f;
    public float padding = 1f;
    public GameObject bullet;

    void Update()
    {
        //Mov. Vertical
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);


        //Mov. Horizontal
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

        //Clamping
        float newX = Mathf.Clamp(transform.position.x, -10 + padding, 10 - padding);
        float newY = Mathf.Clamp(transform.position.y, -10 + padding, 10 - padding);

        transform.position = new Vector3(newX, newY, transform.position.z);

        //Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Poner en marcha
            InvokeRepeating("Fire", 0.001f, 0.25f);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            //Parar el repetidor
            CancelInvoke("Fire");
        }
    }
}
