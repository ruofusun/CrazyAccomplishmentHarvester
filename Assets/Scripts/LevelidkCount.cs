using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelidkCount : MonoBehaviour
{
    public int counter = 0;
    //public GameObject EdaHuge;
    public GameObject EdaHugeM;
    public GameObject EdaHuge;
    //public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DM" || collision.tag == "AWord")
        {
            counter += 1;
            if (counter >= 6)
            {
                Sunset();
            }
        }

    }

    public void Sunset()
    {
        EdaHuge.SetActive(false);
        EdaHugeM.SetActive(true);
        //spriteRenderer.sprite = EdaHugeM;
    }



}
