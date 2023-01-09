using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHammer : MonoBehaviour
{
    public GameObject player;
    public GameObject hammer;

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
        if (collision.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            hammer.SetActive(true);
            Debug.Log("switched tag");
            player.transform.tag = "PlayerWithHammer";
        }
    }
}
