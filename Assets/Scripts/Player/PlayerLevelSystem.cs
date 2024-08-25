using UnityEngine;
using System.Collections.Generic;

public class PlayerLevelSystem : MonoBehaviour
{
    public int playerLevel = 1;
    public int experiencePoints = 0;
    public int experienceToNextLevel = 100;
    public List<Projectile> availableProjectiles = new List<Projectile>();
    public List<Projectile> activeProjectiles = new List<Projectile>();

    public UpgradeUI upgradeUI;

    public void AddExperience(int amount)
    {
        experiencePoints += amount;
        if (experiencePoints >= experienceToNextLevel)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        playerLevel++;
        experiencePoints -= experienceToNextLevel;
        experienceToNextLevel = Mathf.FloorToInt(experienceToNextLevel * 1.5f);

        ShowUpgradeOptions();
    }

    private void ShowUpgradeOptions()
    {
        // Pause the game and display the upgrade options to the player
        Time.timeScale = 0f;

        // Let the player choose which projectile to upgrade
        if (activeProjectiles.Count > 0)
        {
            // Example: For now, just show upgrade options for the first active projectile
            // You can extend this by allowing the player to select which projectile to upgrade
            upgradeUI.ShowStatUpgradeOptions(activeProjectiles[0]);
        }
    }
}

