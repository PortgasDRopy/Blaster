using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    private Transform target;
    public GameObject bullet;
    public float fireRate = 1f;
    public float fireCountdown = 0f;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f); 
    }
    void UpdateTarget()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestPlayer = null;
        foreach (GameObject player in players)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
            if (distanceToPlayer < shortestDistance) 
            { 
                shortestDistance = distanceToPlayer;
                nearestPlayer = player;
            }
            if (nearestPlayer != null && shortestDistance <= 15) 
            {
                target = nearestPlayer.transform;
            }
            else
            {
                target = null;
            }
        }
    }
}
