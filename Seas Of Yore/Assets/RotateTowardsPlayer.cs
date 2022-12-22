using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsPlayer : MonoBehaviour
{
    private Transform _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        Vector3 playerPos = _player.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, playerPos - transform.position);
    }
}
