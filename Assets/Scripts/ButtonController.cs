using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private Animator _animator;

    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            if (other.gameObject.transform.position.y > gameObject.transform.position.y)
            {
                if (!triggered)
                {
                    _animator.SetTrigger("trigger");
                    Fungus.Flowchart.BroadcastFungusMessage ("buttontrigger");
                    
                    triggered = true;
                }
            }
        }
    }
}
