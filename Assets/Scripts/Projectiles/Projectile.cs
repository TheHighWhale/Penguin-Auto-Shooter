using UnityEngine;

[System.Serializable]
public class Projectile
{
    public string projectileName;
    public GameObject projectilePrefab;
    public float damage;
    public float speed;
    public float fireRate; // Spawn frequency
    public int level; // Current level of this projectile

    // Upgrade methods for individual stats
    public void UpgradeDamage(int amount)
    {
        damage += amount;
        level++;
    }

    public void UpgradeSpeed(float amount)
    {
        speed += amount;
        level++;
    }

    public void UpgradeFireRate(float factor)
    {
        fireRate *= factor; // E.g., 0.9f to decrease time between shots (increase fire rate)
        level++;
    }
}
