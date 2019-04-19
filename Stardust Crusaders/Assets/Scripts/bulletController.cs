using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{

    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 12)
        {
            Destroy(gameObject);
            print("Disparo destruido");
        }
    }
}
