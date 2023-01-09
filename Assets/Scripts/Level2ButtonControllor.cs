using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2ButtonControllor : MonoBehaviour
{
    //public Animator camAnimator;
    public GameObject ouch;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.tag == "Player")
        {
            Destroy(ouch, 0.5f);
        }*/
    }
}
