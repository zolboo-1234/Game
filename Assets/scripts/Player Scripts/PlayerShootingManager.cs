using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingManager : MonoBehaviour
{
    
    [SerializeField]
    private float shootingTimerLimit = 0.2f;
    private float shootingTimer;

    [SerializeField]
    private Transform bulletSpawnPos;

    private PlayerWeaponManager playerWeaponManager;

    private void Awake()
    {
        playerWeaponManager = GetComponent<PlayerWeaponManager>();
    }

    private void Update()
    {
        HandleShooting();
    }

    void HandleShooting()
    {

        if(Input.GetMouseButtonDown(0))
        {
            if(Time.time > shootingTimer)
            {

                shootingTimer = Time.time + shootingTimerLimit;

                playerWeaponManager.Shoot(bulletSpawnPos.position);
            }
        }
    }

    void CreateBullet()
    {
        playerWeaponManager.Shoot(bulletSpawnPos.position);
    }
}
