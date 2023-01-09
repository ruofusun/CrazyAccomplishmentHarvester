using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ima;
    float spawnTime = 0.0f;

    GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var playerPos = player.transform.position;


        spawnTime = spawnTime - Time.deltaTime;
        if (spawnTime <= 0)
        {
            //var rockPos = Random.Range(4, 3);

            Vector2 pos = new Vector2(4, 3);
            if(playerPos.x >= 10)
            {
                pos = new Vector2(20, 3);
            }
            //Quaternion.LookRotation()
            int which = Random.Range(0, ima.Length);
            GameObject obj = Instantiate(ima[which], pos, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = (playerPos - transform.position).normalized * 3;


            spawnTime = Random.Range(1.0f, 2.0f);
        }
    }




}
