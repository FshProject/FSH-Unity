using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ColorChange : MonoBehaviour
{
    public GameObject[] objectArray;
    public float[] pitches;

    public int spot;
    public int setPitch;

    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject yellow;

	// Start is called before the first frame update
	void Start()
    {
        spot = 0;

        setPitch = 0;
        pitches = new float[] { 1f, 1.5f, 3f, -2f, -1.5f};

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

	void OnTriggerEnter(Collider other)
	{
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

        else if (other.gameObject.CompareTag("Plane") == false)
        {
            GetComponent<AudioSource>().Play();

            if (setPitch == 4)
            {
                setPitch = 0;
                GetComponent<AudioSource>().pitch = setPitch;
            }

            else
            {
                setPitch++;
                GetComponent<AudioSource>().pitch = setPitch;
            }

        }
	}
}