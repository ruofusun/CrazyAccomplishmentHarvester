using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Animator camAnimator;
    public Camera mainCamera;
    public GameObject ouch;

    private bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {
        camAnimator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("yes, indeed");
            trigger = true;
            //if the camera is on the left screen, trigger move right animation
            if (mainCamera.transform.position.x == 0 && trigger == true)
            {
                camAnimator.Play("Level2_cameraMovement");
                ouch.SetActive(false);
            }
            //if the camera is on the right screen, trigger move left animation
            if (mainCamera.transform.position.x == 16.5 && trigger == true)
            {
                camAnimator.Play("Level2_cameraMoveLeft");
                ouch.SetActive(true);
                Fungus.Flowchart.BroadcastFungusMessage("stop");
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            trigger = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("goodbye");
            trigger = false;
        }
    }
}
