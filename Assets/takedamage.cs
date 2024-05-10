using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class takedamage : MonoBehaviour
{
    public float life = 10000;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //LayerMask.GetMask(TagManager.BLOCKING_LAYER_MASK);

            Destroy(gameObject);
            Destroy(collision.gameObject);
            
    }
    

    
}
