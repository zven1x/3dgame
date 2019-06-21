using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  
    [SerializeField]
    private float sensitivity = 0.3f;
    private CinemachineComposer composer;
    /// <summary>
    /// Do metody Start dodajemy pola ktore wykonuje pobieranie elementow z klasy 
    /// </summary>
   private void Start()
    {
        composer = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineComposer>();

    }

    /// <summary>
    /// do metody Update dodajemy pola ktore daje poprawnej pracy ruchu camery za pomoca myszy.
    /// </summary>
   private void Update()
    {
        float vertical = Input.GetAxis("Mouse Y") * sensitivity;
        composer.m_TrackedObjectOffset.y += vertical;
        composer.m_TrackedObjectOffset.y = Mathf.Clamp(composer.m_TrackedObjectOffset.y, -10, 10);


    }
}
