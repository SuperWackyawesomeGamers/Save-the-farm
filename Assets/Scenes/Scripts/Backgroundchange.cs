using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Backgroundchange : MonoBehaviour
{
    PlayableDirector director;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
      animator = GameObject.Find("JLNewbackground").GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator.Play("JLBackgroundAnimation");
        }
        else
        {
            animator.Play("New State");
        }

    }
}
