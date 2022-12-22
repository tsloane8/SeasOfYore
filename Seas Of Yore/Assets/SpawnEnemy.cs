using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject _enemyPrefab;
    public float spawnerRadius = 10f;
    public bool canSpawn = true;
    private float spawnTime = 3f;


    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;

        if (canSpawn && spawnTime <= 0f)
        {
            SpawnEnemies();
            spawnTime = 9f;
        }
        else
        {
            Debug.Log("Waiting...");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canSpawn = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canSpawn = true;
        }
    }
    void SpawnEnemies()
    {
        float randNum = Random.Range(0f, 100f);

        if(randNum < 30f)
        {
            Instantiate(_enemyPrefab, transform.position, transform.rotation);
        }
        else
        {
            Debug.Log("Waiting...");
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, spawnerRadius);
    }
}
