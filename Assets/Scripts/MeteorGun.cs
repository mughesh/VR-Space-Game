using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class MeteorGun : MonoBehaviour
{   
    public ParticleSystem particles;
    public LayerMask layerMask;
    public Transform shootSource;
    public float distance = 10;
    private bool gunActivated = false;


    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x=> startShoot());
        grabInteractable.deactivated.AddListener(x=> stopShoot());
    }

    public void startShoot()
    {
        particles.Play();
        gunActivated = true;
        //Debug.Log("Trigger button pressed");
    }

    public void stopShoot()
    {
        particles.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);
        gunActivated = false;
    }

    void RaycastHitCheck()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(shootSource.position,shootSource.forward,out hit,distance,layerMask);
        if (hasHit)
        {
            hit.transform.gameObject.SendMessage("Break",SendMessageOptions.DontRequireReceiver);
            Debug.Log("raycast Hit !!!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(gunActivated)
        {
            RaycastHitCheck();
        }
        
    }
}
