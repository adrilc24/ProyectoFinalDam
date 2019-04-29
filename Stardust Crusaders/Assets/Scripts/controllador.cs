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
    [Header("Movimiento")]
    public float speed = 12f;
    public float padding = 1f;
    [Header("HP")]
    [SerializeField] int hp = 100;

    public GameObject bulletFighter;

    void Update()
    {
        Movimiento();

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.gameObject.GetComponent<DamageDealer>();
        if (!damageDealer) { return; }
        ProcessHit(damageDealer);
    }

    private void ProcessHit(DamageDealer damageDealer)
    {
        hp -= damageDealer.GetDamage();
        damageDealer.Hit();
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Movimiento()
    {
        //Mov. Vertical
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);


        //Mov. Horizontal
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

        //Clamping
        float newX = Mathf.Clamp(transform.position.x, -9 + padding, 9 - padding);
        float newY = Mathf.Clamp(transform.position.y, -15 + padding, 15 - padding);

        transform.position = new Vector3(newX, newY, transform.position.z);
    }


    void Fire()
    {
        var fighter = GameObject.Find("Nave");
        if (fighter != null)
        {
            Vector3 newPosition = fighter.transform.position + Vector3.up * 0.3f + Vector3.up * 0.5f;
            Instantiate(bulletFighter, newPosition, Quaternion.identity);

        }
    }

}
