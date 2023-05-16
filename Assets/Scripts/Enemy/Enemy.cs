using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    int damage = 10;
    GameManager GM;

    public int maxHealth = 20;
    public int currentHealth;
    public Slider slider;

    private Transform target;
    private int wavepointIndex = 0;
    

    void Start()
    {
        currentHealth = maxHealth;
        slider.value = maxHealth;
        target = Waypoints.points[0];
        GM = FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        MoveEnemy();
        slider.value = currentHealth;
    }

    void MoveEnemy()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        
        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            GetNextWayPoint();
        }

        void GetNextWayPoint()
        {
            if (wavepointIndex >= Waypoints.points.Length - 1)
            {
                Destroy(gameObject);
                GM.currentHealth -= damage;
                return;
            }
            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];
        }

    }
}
