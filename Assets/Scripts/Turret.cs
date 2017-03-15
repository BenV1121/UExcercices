using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject player;
    public GameObject bulletPrefab;

    public float launchForce = 10.0f;

    public Transform firePoint;

    public float firingInterval = 1.0f;
    private float firingTimer;

    public float firingRadius = 15.0f;

    bool IsPlayerInRange()
    {
        return (player.transform.position - transform.position).magnitude < firingRadius;
    }

    void start()
    {
        firingTimer = firingInterval;
    }

	void Update ()
    {
        bool inRange = IsPlayerInRange();

        if(inRange)
        {
            Vector3 newForward = (player.transform.position - transform.position).normalized;
            transform.forward = newForward;
        }

        firingTimer -= Time.deltaTime;

        if (firingTimer <= 0.0f && inRange)
        {
            GameObject babyBullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            babyBullet.GetComponent<Rigidbody>().AddForce(firePoint.forward * launchForce);

            firingTimer = firingInterval;
        }
	}

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, firingRadius);
    }
}
