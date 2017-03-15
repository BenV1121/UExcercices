using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosives : MonoBehaviour
{
    public float explosionForce = 15;
    public float explosionUpward = 1;
    public float explosionRadius = 5;

	// Use this for initialization
	void OnCollisionEnter (Collision collision)
    {
        Collider[] nearbyColliders = Physics.OverlapSphere(transform.position, explosionRadius);

        for(int i = 0; i < nearbyColliders.Length; ++i)
        {
            Rigidbody targetRbody = nearbyColliders[i].GetComponent<Rigidbody>();
            if(targetRbody != null)
            {
                targetRbody.AddExplosionForce;
            }
        }
        Destroy(gameObject);
	}
}
