using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform _player;

    [Header("Acceleration")]
    [SerializeField] private float verticalInputAcceleration = 1;
    [Header("Speed")]
    [SerializeField] private float maxSpeed;
    [Header("Drag")]
    [SerializeField] private float velocityDrag = 1;

    private Vector3 velocity;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        // apply forward input
        Vector3 acceleration = verticalInputAcceleration * transform.up;
        velocity += acceleration * Time.deltaTime;

        Vector3 playerPos = _player.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, playerPos);
    }

    private void FixedUpdate()
    {
        // apply velocity drag
        velocity = velocity * (1 - Time.fixedDeltaTime * velocityDrag);

        // clamp to maxSpeed
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        // update transform
        transform.position += velocity * Time.fixedDeltaTime;
    }
}
