using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public GameObject otherTeleporter;
    public Transform teleportDestination;

    public float teleportationTimeout = 2.0f;
    public float teleportationTimer;

    public void Update()
    {
        teleportationTimer -= Time.deltaTime;
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (teleportationTimer > 0.0f) { return; }

        teleportationTimer = teleportationTimeout;
        otherTeleporter.GetComponent<Teleporter>().teleportationTimer = teleportationTimeout;

        collision.transform.position = otherTeleporter.transform.position;
    }

    public void RecieveObject(GameObject package, float timeout)
    {
        package.transform.position = teleportDestination.position;

        teleportationTimer = timeout;

        otherTeleporter.GetComponent<Teleporter>().teleportationTimer = teleportationTimeout;
    }
}
