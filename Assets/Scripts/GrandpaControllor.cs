using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class GrandpaControllor : MonoBehaviour
{
    public GameObject button;
    public GameObject fakeButton;

    private Animator animGrandpa;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Fungus.Flowchart.BroadcastFungusMessage("grandpaMessage");
            button.SetActive(false);
            fakeButton.SetActive(true);

            if (Input.GetKeyDown(KeyCode.H))
            {
                animGrandpa.Play("GrandpaHappy");
            }
        }
        
    }
}
