using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour

{

	[SerializeField]

	[Range(0.1f, 1.5f)]
    // tworzenie zmiennej dla okresowosci strzal.
	private float fireRate = 0.3f;



	[SerializeField]

	[Range(1, 10)]
    // stworzenie zmiennej dla poziomy uszkodzenia.
	private int damage = 1;



	





	private float timer;


    /// <summary>
    /// metoda jest wywolana po kliknieciu "Fire1" .
    /// jest stworzona dla poprawnej pracy okresowosci strzal oraz wywoluje metod FireGun.
    /// </summary>
	void Update()

	{

		timer += Time.deltaTime;
		if (timer >= fireRate)

		{

			if (Input.GetButton("Fire1"))

			{

				timer = 0f;

				FireGun();

			}

		}

	}


    /// <summary>
    /// metoda FireGun wywoluje sie po wykonaniu metody Update.
    /// tworzy niewidzialny promien ktory zadaje uszkodzienie oraz wywoluje metod TakeDamage z klasy health. 
    /// </summary>
	private void FireGun()

	{



        Ray ray = Camera.main.ViewportPointToRay(Vector3.one * 0.5f);

        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 2f);

        RaycastHit hitInfo;



		if (Physics.Raycast(ray, out hitInfo, 100))

		{
            Destroy(hitInfo.collider.gameObject);
			var health = hitInfo.collider.GetComponent<Health>();



			if (health != null)

			health.TakeDamage(damage);

		}

	}

}