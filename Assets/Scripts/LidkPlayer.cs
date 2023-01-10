using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidkPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EdaM")
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene("TurtleFlipOver");
            Fungus.Flowchart.BroadcastFungusMessage("Loading");
        }

        if(collision.tag == "AWord")
        {
            Fungus.Flowchart.BroadcastFungusMessage("Achievement");
        }
    }

    
}
