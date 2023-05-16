using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.Instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void SelectSniperTurret()
    {
        Debug.Log("Sniper Turret Selected");
        buildManager.SetTurretToBuild(buildManager.sniperTurretPrefab);
    }

    public void SelectMissileTurret()
    {
        Debug.Log("Missile Turret Selected");
        buildManager.SetTurretToBuild(buildManager.missileTurretPrefab);
    }
    public void SelectDamageBuff()
    {
        Debug.Log("Damage Buff Selected");
        buildManager.SetTurretToBuild(buildManager.damageBuffPrefab);
    }
    public void SelectRateBuff()
    {
        Debug.Log("Rate Buff Selected");
        buildManager.SetTurretToBuild(buildManager.rateBuffPrefab);
    }
    public void SelectRangeBuff()
    {
        Debug.Log("Select Range Selected");
        buildManager.SetTurretToBuild(buildManager.rangeBuffPrefab);
    }
}
