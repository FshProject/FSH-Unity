using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class ColorChange : MonoBehaviour
{

    //public AudioClip clip;

    public GameObject[] objectArray;

    public int spot;

    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject yellow;

	// Start is called before the first frame update
	void Start()
    {
        spot = 0;

        red.SetActive(true);
        blue.SetActive(false);
        green.SetActive(false);
        yellow.SetActive(false);

        objectArray = new GameObject[4];
        objectArray[0] = red;
        objectArray[1] = blue;
        objectArray[2] = green;
        objectArray[3] = yellow;

    }

	void OnTriggerExit(Collider other)
	{
        //AudioSource.Play();
        if (other.gameObject.CompareTag("Fish"))
        {
            objectArray[spot].SetActive(false);
            objectArray[spot + 1].SetActive(true);

            if (spot == 3)
            {
                spot = 0;
            }

            else
            {
                spot++;
            }
        }
	}
}