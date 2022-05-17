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
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;

        }else if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }


        if(Input.GetKeyDown(KeyCode.Space))
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
    