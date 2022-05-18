using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public BulletMovement bulletPrefab;
    public float speed = 5.0f;
    private bool bulletActive;

    private void Update()
    {


        float xMove = Input.GetAxisRaw("Horizontal");
        float xMovement = xMove * speed * Time.deltaTime;

        transform.Translate(xMovement, 0, 0);


        if (Input.GetKey(KeyCode.Return))
        {
            
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            Shoot();

        }
    }

    private void Shoot()
    {
        if (!bulletActive)
        {
            BulletMovement projectile = Instantiate(this.bulletPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += BulletDestroyed;
            bulletActive = true;

        }     
    }
    private void BulletDestroyed()
    {
        bulletActive = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainScene");
        }
    }

}
    