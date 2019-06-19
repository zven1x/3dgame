using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class PlayerMovement : MonoBehaviour

{
    //tworzenie zmiennej dla controlera.
    private CharacterController characterController;
    //tworzenie zmiennej dla animacji.
    private Animator animator;



    [SerializeField]
    // tworzenie zmiennej dla szybkosci dla chodzienia naprzod.
    private float forwardMoveSpeed = 100;
    [SerializeField]
    // tworzenie zmiennej dla szybkosci dla chodzienia do tylu.
    private float backMoveSpeed = 100;



    [SerializeField]
    // tworzenie zmiennej dla szybkosci obrotu ciala
    private float turnSpeed = 5f;


    /// <summary>
    /// metoda jest stworzona dla pobierania komponentow z metod.
    /// </summary>
    private void Awake()

    {

        characterController = GetComponent<CharacterController>();

        animator = GetComponentInChildren<Animator>();

    }


    /// <summary>
    /// metoda jest stworzona dla poprawnej pracy ruchy postaci oraz dzielania animacji.
    /// </summary>
    private void Update()

    {

        var horizontal = Input.GetAxis("Horizontal");

        var vertical = Input.GetAxis("Vertical");



        var movement = new Vector3(horizontal, 0, vertical);

        animator.SetFloat("Speed", vertical);

        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);


        if (vertical != 0)

        {

            float moveSpeedToUse = (vertical > 0) ? forwardMoveSpeed : backMoveSpeed;

            characterController.SimpleMove(transform.forward * moveSpeedToUse * vertical);

        }

    }

}