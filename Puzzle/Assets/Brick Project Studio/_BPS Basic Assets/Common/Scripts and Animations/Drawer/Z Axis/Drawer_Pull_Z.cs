using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class Drawer_Pull_Z : MonoBehaviour
	{
		public GameObject hand;
		
		public AudioSource drawerSound;
		
		public Animator pull;
		public bool open;
		public Transform Player;

		void Start()
		{
			open = false;
		}

		void OnMouseOver()
		{
			{
				if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 3)
					{
						hand.SetActive(true);
						if (open == false)
						{
							if (Input.GetButtonDown("Action"))
							{
								StartCoroutine(opening());
							}
						}
						else
						{
							if (open == true)
							{
								if (Input.GetButtonDown("Action"))
								{
									StartCoroutine(closing());
								}
							}

						}

					}
				}

			}

		}

		void OnMouseExit(){
			hand.SetActive(false);
		}

		IEnumerator opening()
		{
			print("you are opening the door");
			pull.Play("openpull");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			pull.Play("closepush");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}