using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public GameObject _enemy;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(_enemy.transform.position.x - 0.729f, _enemy.transform.position.y + 2);
    }
}
