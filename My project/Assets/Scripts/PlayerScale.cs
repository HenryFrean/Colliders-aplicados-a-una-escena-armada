using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScale : MonoBehaviour
{
    private int timeOnTrigger = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            timeOnTrigger++;

            if (timeOnTrigger % 3 == 1)
            {
                transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                Debug.Log("El player ingreso al collider del: " + other.gameObject.name);
            }

            else
            {     
                transform.localScale = new Vector3(1f, 1f, 1f);
                Debug.Log("El player ingreso al collider del: " + other.gameObject.name);
            }
        }
    }
}
