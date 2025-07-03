using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIinteractionMessage;
    // Start is called before the first frame update
    void Start()
    {
        UIinteractionMessage.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        MercaderiaScript mercaderia = other.GetComponent<MercaderiaScript>();
        if (mercaderia) {
                    UIinteractionMessage.SetActive(true);


        }
    }
    private void OnTriggerExit(Collider other)
    {
        MercaderiaScript mercaderia = other.GetComponent<MercaderiaScript>();

            UIinteractionMessage.SetActive(false);
            mercaderia = null;
    }
}
