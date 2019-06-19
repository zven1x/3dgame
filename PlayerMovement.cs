using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerMovement : MonoBehaviour

{

    private CharacterController characterController;

    private Animator animator;



    [SerializeField]

    private float forwardMoveSpeed = 100;
    [SerializeField]

    private float backMoveSpeed = 100;



    [SerializeField]

    private float turnSpeed = 5f;



    private void Awake()

    {

        characterController = GetComponent<CharacterController>();

        animator = GetComponentInChildren<Animator>();

    }



    private void Update()

    {

        var horizontal = Input.GetAxis("Horizontal");

        var vertical = Input.GetAxis("Vertical");



        var movement = new Vector3(horizontal, 0, vertical);



        //characterController.SimpleMove(movement * Time.deltaTime * moveSpeed);
        animator.SetFloat("Speed", vertical);

        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);


        if (vertical != 0)

        {

            float moveSpeedToUse = (vertical > 0) ? forwardMoveSpeed : backMoveSpeed;

            characterController.SimpleMove(transform.forward * moveSpeedToUse * vertical);

        }

    }

}