using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entrando en colision con: " + other.gameObject.name);
    }
}
