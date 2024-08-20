using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPressDoorOpen : MonoBehaviour
{   
    public Animator animator;
    private string boolName = "Open";

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleOpenDoor());
    }

    public void ToggleOpenDoor()
    {
        bool isOpen = animator.GetBool(boolName);
        animator.SetBool(boolName,!isOpen);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
