using System;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    [SerializeField]
    GameObject shotPrefab;

    [SerializeField]
    int shotSpeed = 10;

    [SerializeField]
    Transform spawnpoint;

    [SerializeField]
    float shotCooldown = 0.5f;

    float lastShotTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > lastShotTime + shotCooldown)
        {
            var bullet = Instantiate(shotPrefab, spawnpoint.position, spawnpoint.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = spawnpoint.forward * shotSpeed;
            lastShotTime = Time.time;
        }
    }
}
