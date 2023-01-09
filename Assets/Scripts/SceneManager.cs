using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("next plz");
            Fungus.Flowchart.BroadcastFungusMessage("loadNextScene");

        }
    }
}

