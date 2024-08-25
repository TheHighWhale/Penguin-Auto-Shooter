using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public PlayerLevelSystem playerLevelSystem;

    private float lastShotTime;

    void Update()
    {
        foreach (var projectile in playerLevelSystem.activeProjectiles)
        {
            if (Time.time > lastShotTime + projectile.fireRate)
            {
                Shoot(projectile);
                lastShotTime = Time.time;
            }
        }
    }

    void Shoot(Projectile projectile)
    {
        Instantiate(projectile.projectilePrefab, transform.position, Quaternion.identity);
    }
}
