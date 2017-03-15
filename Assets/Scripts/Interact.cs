using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteract
{
    float Interaction(float inter);
}

public class Interact : MonoBehaviour 
{
    //public float interactDistance = 5f;

	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            float interactDistance = 5f;

            float Interaction(float inter)
            {
                return interactDistance;
            }

            if (Physics.Raycast(ray, out hit, InteractDistance))
            {
                 if(hit.collider.CompareTag("Door"))
                {
                    hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
                }
            }
        }
	}
}
