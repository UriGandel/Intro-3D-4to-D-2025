using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeColisiones : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
