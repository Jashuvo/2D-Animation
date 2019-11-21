using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControllerScript : MonoBehaviour
{
    public Animator animationController;
    // Start is called before the first frame update
    void Start()
    {
        animationController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animationController.SetBool("swing", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            animationController.SetBool("swing", false);
        }
        float playerWalk = Input.GetAxis("Horizontal");
        animationController.SetFloat("walk", playerWalk);
    }
}
