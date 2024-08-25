using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour
{
    public GameObject upgradePanel;
    public Button[] statUpgradeButtons; // Buttons for each stat upgrade
    public PlayerLevelSystem playerLevelSystem;

    private Projectile selectedProjectile;

    public void ShowStatUpgradeOptions(Projectile projectile)
    {
        upgradePanel.SetActive(true);
        selectedProjectile = projectile;

        // Assign each button to upgrade a specific stat
        statUpgradeButtons[0].GetComponentInChildren<Text>().text = "Upgrade Damage";
        statUpgradeButtons[0].onClick.RemoveAllListeners();
        statUpgradeButtons[0].onClick.AddListener(() => UpgradeDamage());

        statUpgradeButtons[1].GetComponentInChildren<Text>().text = "Upgrade Speed";
        statUpgradeButtons[1].onClick.RemoveAllListeners();
        statUpgradeButtons[1].onClick.AddListener(() => UpgradeSpeed());

        statUpgradeButtons[2].GetComponentInChildren<Text>().text = "Upgrade Fire Rate";
        statUpgradeButtons[2].onClick.RemoveAllListeners();
        statUpgradeButtons[2].onClick.AddListener(() => UpgradeFireRate());
    }

    private void UpgradeDamage()
    {
        selectedProjectile.UpgradeDamage(5); // Example increment
        upgradePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void UpgradeSpeed()
    {
        selectedProjectile.UpgradeSpeed(0.5f); // Example increment
        upgradePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void UpgradeFireRate()
    {
        selectedProjectile.UpgradeFireRate(0.9f); // Example multiplier (reduces time between shots)
        upgradePanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
