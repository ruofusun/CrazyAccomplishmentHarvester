using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class GrandpaControllor : MonoBehaviour
{
    public GameObject button;
    public GameObject fakeButton;

    private Animator animGrandpa;

    private void Start()
    {
        animGrandpa = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Fungus.Flowchart.BroadcastFungusMessage("grandpaMessage");
            button.SetActive(false);
            fakeButton.SetActive(true);
        }       
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "PlayerWithHammer")
        {
            Debug.Log("hammer detected");

            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("chuibei time");
                animGrandpa.Play("GrandpaHappy");
                Fungus.Flowchart.BroadcastFungusMessage("chuibei");
            }
            
        }

    }
}
