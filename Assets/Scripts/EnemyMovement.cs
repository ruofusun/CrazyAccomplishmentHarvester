using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    private Transform target;
    public Transform Sun;
    bool attack = false;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(attack == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //var sunPos = Sun.transform.position;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hammer")
        {
            Getit();
            //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void Getit()
    {
        attack = true;
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

}
