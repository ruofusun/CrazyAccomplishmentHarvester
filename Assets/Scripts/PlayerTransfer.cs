using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransfer : MonoBehaviour
{
    public bool isSmartTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            other.gameObject.transform.position = transform.GetChild(0).position;
        }
        if(isSmartTrigger)
        {
            Fungus.Flowchart.BroadcastFungusMessage ("smarttrigger");
        }
    }

        
    }

