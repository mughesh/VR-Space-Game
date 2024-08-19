using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{   
    public List<GameObject> breakable;
    public float timeToBreak = 2.0f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in breakable)
        {
            item.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Break()
    {   
        timer += Time.deltaTime;
        if (timer > timeToBreak)
        {
            foreach (var item in breakable)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }
            gameObject.SetActive(false);
        }
        
    }
}
