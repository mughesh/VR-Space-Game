using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{   
    public string targetTag;
    public UnityEvent<GameObject> OnEnterEvent;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == targetTag)
        {
            OnEnterEvent.Invoke(other.gameObject);
        }
    }
}
