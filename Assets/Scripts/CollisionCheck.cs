using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour 
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider trigger)
    {
        Debug.Log(trigger.name);
        if (trigger.name == "Dolly_RigMaybe")
        {
            Application.LoadLevel("Title");
        }
    }
}
