using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("More than one BuildManager in scene!");
            return;
        }
        Instance= this;
    }

    public GameObject standardTurretPrefab;
    public GameObject sniperTurretPrefab;
    public GameObject missileTurretPrefab;
    public GameObject damageBuffPrefab;
    public GameObject rateBuffPrefab;
    public GameObject rangeBuffPrefab;

    private GameObject turretToBuild;

    public GameObject getTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turretToBuild = turret;
    }

}
