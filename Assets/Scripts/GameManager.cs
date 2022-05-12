using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public GameObject enemyPrefab;
    public Transform[] enemySpawnPoints;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 1);
        //spawn enemies starting at x, every y
    }


    // Update is called once per frame
    void Update()
    {

    }


    void SpawnEnemy()
    {
        int index = Random.Range(0, enemySpawnPoints.Length);
        Vector3 spawnPos = enemySpawnPoints[index].position;

        GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        //enemy.GetComponent<SpriteRenderer>().color = new Color
        //    (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        int dirModifier = 1;
        //if (index > 2)
        //{
        //    dirModifier = -1;
        //    enemy.GetComponent<SpriteRenderer>().flipX = true;
        //}


        enemy.GetComponent<EnemyMovement>().speed = Random.Range(3.0f, 6.0f);

        enemy.GetComponent<EnemyMovement>().speed *= dirModifier;

    }






}
