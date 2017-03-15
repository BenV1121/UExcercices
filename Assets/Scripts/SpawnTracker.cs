using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTracker : MonoBehaviour
{
    public Spawner origin;

	// Use this for initialization
	void OnDestroy ()
    {
        origin.objNum--;
	}
}
