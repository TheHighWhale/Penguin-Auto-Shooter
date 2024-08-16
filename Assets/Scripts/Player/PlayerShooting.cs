using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float fireRate = 0.2f;
    public int maxProjectiles = 6;
    public int startingProjectiles = 1;
    private int currentProjectiles;

    private float nextFireTime = 0f;
    private List<GameObject> activeProjectiles = new List<GameObject>();

    private void Start()
    {
        currentProjectiles = startingProjectiles;
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime && activeProjectiles.Count < maxProjectiles)
        {
            nextFireTime = Time.time + fireRate;
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            activeProjectiles.Add(projectile);

            // Add logic to manage projectile lifetime or pooling here
        }
    }

    private void ManageProjectiles()
    {
        // Iterate through active projectiles, removing those that are no longer needed
        // This could be based on lifetime, going off screen, or other conditions
        for (int i = activeProjectiles.Count - 1; i >= 0; i--)
        {
            if (activeProjectiles[i] == null || !activeProjectiles[i].activeInHierarchy)
            {
                activeProjectiles.RemoveAt(i);
            }
        }
    }
}
