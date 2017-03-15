using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public new GameObject camera;

    public float Force;

    public float xForce;
    public float yForce;

    public bool canMove;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }

        transform.rotation = Quaternion.Euler(0, camera.GetComponent<MouseLook>().currentYRotation, 0);

        xForce = Input.GetAxis("Horizontal") * Force;
        yForce = Input.GetAxis("Vertical") * Force;

        transform.Translate(new Vector3(xForce, 0, yForce));
    }
}
