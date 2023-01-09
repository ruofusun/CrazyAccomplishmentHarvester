using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLevelidk : MonoBehaviour
{
    public Animator camAnimator;
    public Camera mainCamera;

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
            //if the camera is on the left screen, trigger move right animation
            if (mainCamera.transform.position.x == 0)
            {
                camAnimator.Play("CamMLevelidk-toRight");
            }
            //if the camera is on the right screen, trigger move left animation
            if (mainCamera.transform.position.x == 16.5)
            {
                camAnimator.Play("CamMLevelidk-toLeft");
            }
        }
    }
}
