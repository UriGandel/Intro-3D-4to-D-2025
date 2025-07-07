using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionParkour : MonoBehaviour
{
    public GameObject UIinteractionMessage;
    public bool canInteract;
    public ScoreManager scoreManager;
    public MercaderiaScript mercaderiaScript;
    public GameObject currentInteractable;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        UIinteractionMessage.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null && canInteract)
        {
            Destroy(currentInteractable);
            scoreManager.AddScore(currentInteractable.GetComponent<MercaderiaScript>().scorepoints);
            currentInteractable = null;
            EndInteraction();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Interactable"))
        {
            UIinteractionMessage.SetActive(true);
            canInteract = true;
            currentInteractable = other.gameObject;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Interactable") && other.gameObject == currentInteractable)
        {
            EndInteraction();
        }
    }
    void EndInteraction()
    {
        UIinteractionMessage.SetActive(false);
        canInteract = false;
        currentInteractable = null;
    }
}
