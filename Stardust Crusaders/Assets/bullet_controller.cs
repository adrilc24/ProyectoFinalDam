using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controller : MonoBehaviour
{
    public float bulletSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(bulletSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Destruir Bala
        if (transform.position.x > 10.5)
        {
            Destroy(gameObject);
        }
    }
}
