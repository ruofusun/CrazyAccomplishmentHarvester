using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class HammerButton : MonoBehaviour
{
    public GameObject pressH;
    public Animation animHammer;

    // Start is called before the first frame update
    void Start()
    {
        animHammer.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            animHammer.Play("HammerUp");
            pressH.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pressH.SetActive(true);
            Fungus.Flowchart.BroadcastFungusMessage("pissed");

        }
    }
}
