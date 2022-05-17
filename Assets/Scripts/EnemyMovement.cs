using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 5.0f;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        float yValue = speed * Time.deltaTime;
        transform.Translate(0, yValue, 0);
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
