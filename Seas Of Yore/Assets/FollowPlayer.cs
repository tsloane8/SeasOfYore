using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform _player;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_player.position.x, _player.position.y, -10);
    }
}
