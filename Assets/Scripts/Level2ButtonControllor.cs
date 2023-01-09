using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Level2ButtonControllor : MonoBehaviour
{
    //public Animator camAnimator;
    public GameObject ouch;
    public GameObject grandpa;

    // Start is called before the first frame update
    void Start()
    {
        //camAnimator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(ouch, 0.5f);
            Fungus.Flowchart.BroadcastFungusMessage("cleared");
        }
    }
}
