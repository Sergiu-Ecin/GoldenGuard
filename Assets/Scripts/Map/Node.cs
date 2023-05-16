using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    //public Vector3 positionOffset;
    public float yhight = 1;
    int maxTurret;
    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.Instance;
    }

    void OnMouseDown()
    {

        if (buildManager.getTurretToBuild() == null)
        {
            return;
        }

        //if (turret!= null)
        //{
        //    Debug.Log("Cant Build there - TODO: Display on screen");
        //    return;
        //}
        if (maxTurret < 3)
        {
            GameObject turretToBuild = BuildManager.Instance.getTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + Vector3.up * yhight, transform.rotation);
            yhight++;
            maxTurret++;
        }

    }
    void OnMouseEnter()
    {
        if (buildManager.getTurretToBuild() == null)
        {
            return;
        }
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
