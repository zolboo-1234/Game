using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    
    [SerializeField]public float movSpeed = 1f;
    float speedX, SpeedY;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        SpeedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector2(speedX, SpeedY);
    }

}
