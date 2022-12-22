using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour
{
    public GameObject _bulletPrefab;
    public GameObject _bulletLauncher;
    private float bulletDelay = 2f;

    // Update is called once per frame
    void Update()
    {
        bulletDelay -= Time.deltaTime;
        if(bulletDelay <= 0)
        {
            Shoot();
            bulletDelay = 2f;
        }
    }

    private void Shoot()
    {
        Instantiate(_bulletPrefab, _bulletLauncher.transform.position, _bulletLauncher.transform.rotation);
    }
}
