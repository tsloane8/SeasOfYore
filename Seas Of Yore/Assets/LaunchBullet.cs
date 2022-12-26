using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour
{
    public GameObject _bulletPrefab;
    public GameObject _bulletLauncher;
    private float startCountdown = 2f;
    private float countdown;

    private PlayerStats _playerStats;

    private void Awake()
    {
        _playerStats = GetComponent<PlayerStats>();
        startCountdown = startCountdown - _playerStats.attackSpeedMultiplier;
        countdown = startCountdown;
    }
    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        Debug.Log(countdown);

        if(countdown <= 0)
        {
            Shoot();
            countdown = startCountdown;
            Debug.Log(countdown);
        }
    }

    private void Shoot()
    {
        Instantiate(_bulletPrefab, _bulletLauncher.transform.position, _bulletLauncher.transform.rotation);
    }
}
