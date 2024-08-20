using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VfxActivator : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;
    public ParticleSystem particle;
    public GameObject hologram;
    public string objectName = "Energy";

    // Start is called before the first frame update
    void Start()
    {
        socketInteractor.selectEntered.AddListener(OnObjectPlaced);
        hologram.SetActive(false);
    }

    private void OnObjectPlaced(SelectEnterEventArgs args)
    {
        // Check if the object placed in the socket is the specific one
        if (args.interactableObject.transform.name == objectName)
        {
            // Trigger the particle emission
            particle.Play();
            hologram.SetActive(true);
        }
    }

}
