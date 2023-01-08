using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Fungus;
using Sirenix.OdinInspector;
using UnityEngine;
using Collision2D = UnityEngine.Collision2D;

public class ButtonController : MonoBehaviour
{
    private Animator _animator;

    private bool triggered = false;

    private bool canChasePlayer = false;
    private Rigidbody2D rb2d;

    private CharacterController2D _characterController2D;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _characterController2D = FindObjectOfType<CharacterController2D>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private Tween currentTween = null;
    // Update is called once per frame
    void Update()
    {
        if (canChasePlayer)
        {
            float dis = _characterController2D.transform.position.x - transform.position.x;
            //|| (currentTween!=null&&currentTween.IsPlaying() && Mathf.Abs(dis)>3f)
            if (currentTween == null|| (currentTween!=null&&!currentTween.IsPlaying()))
            {
               
                if (Mathf.Abs(dis) > 4)
                {
                    currentTween =
                        rb2d.DOMove(new Vector2(_characterController2D.transform.position.x+ dis/Mathf.Abs(dis)*1.5f, rb2d.position.y), Mathf.Min(Mathf.Abs(dis)/2, 2f));
                }
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            if (other.gameObject.transform.position.y > gameObject.transform.position.y)
            {
                if (!triggered)
                {
                    _animator.SetTrigger("trigger");
                    Fungus.Flowchart.BroadcastFungusMessage ("buttontrigger");
                    
                    triggered = true;
                }
            }
        }

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Contains("turtle"))
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("flip");
            Fungus.Flowchart.BroadcastFungusMessage ("FlipTurtle");
        }
    }

    [Button]
    public void TweenTest()
    {
        rb2d.DOMove(new Vector2(_characterController2D.transform.position.x, rb2d.position.y), 1f);
    }

    public void StartChasePlayer()
    {
        canChasePlayer = true;
    }

    public void StopChasePlayer()
    {
        canChasePlayer = false;
    }
}
