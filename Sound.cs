using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sound : MonoBehaviour
{
    public TMP_Text infoBox;

    public AudioClip Marsclip1;
    public AudioClip Marsclip2;
    public AudioClip EarthClip1;
    public AudioClip EarthClip2;
    public AudioClip MercuryClip1;
    public AudioClip MercuryClip2;
    public AudioClip VenusClip1;
    public AudioClip VenusClip2;
    public AudioClip SunClip1;
    public AudioClip SunClip2;
    public AudioClip MoonClip1;
    public AudioClip MoonClip2;

    AudioSource audioSource;

    string UIState = "void"; //starting point
    int infoID = 1; //pointer to info text

    string marsText1 = "Let's go visit";
    string marsText2 = "The surface of Mars is orange-red because it is covered in iron oxide dust, giving it the nickname the Red Planet.\n";
    string earthText1 = "It's Our Home";
    string earthText2 = "Only planet where living organism are present.Earth is 30% water and 70% land.\n";
    string mercuryText1 = "I am the smallest.\n";
    string mercuryText2 = "Mercury is named after the Roman god Mercurius, god of commerce and communication, and the messenger of the gods..\n";
    string venusText1 = "Second planet from the sun.\n";
    string venusText2 = "venus is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth.\n";
    string sunText1 = "I am a star.\n";
    string sunText2 = "The Sun is the star at the center of the Solar System. It is a massive, hot ball of plasma which is heated by energy produced by nuclear fusion .\n";
    string moonText1 = "I am Earth's only natural satellite.\n";
    string moonText2 = "The moon is the fifth-largest satellite in the solar system and is one-fourth the size of the Earth.\n";

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//left mouse click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.tag == "mars")
                {
                    UIState = "Mars";
                    infoID = 1;
                    infoBox.text = marsText1;
                    audioSource.PlayOneShot(Marsclip1, 1f);
                }
                else if (hit.transform.tag == "earth")
                {
                    UIState = "Earth";
                    infoID = 1;
                    infoBox.text = earthText1;
                    audioSource.PlayOneShot(EarthClip1, 1f);
                }
                else if (hit.transform.tag == "mercury")
                {
                    UIState = "Mercury";
                    infoID = 1;
                    infoBox.text = mercuryText1;
                    audioSource.PlayOneShot(MercuryClip1, 1f);
                }
                else if (hit.transform.tag == "venus")
                {
                    UIState = "Venus";
                    infoID = 1;
                    infoBox.text = venusText1;
                    audioSource.PlayOneShot(VenusClip1, 1f);
                }
                else if (hit.transform.tag == "sun")
                {
                    UIState = "Sun";
                    infoID = 1;
                    infoBox.text = sunText1;
                    audioSource.PlayOneShot(SunClip1, 1f);
                }
                else if (hit.transform.tag == "moon")
                {
                    UIState = "Moon";
                    infoID = 1;
                    infoBox.text = moonText1;
                    audioSource.PlayOneShot(MoonClip1, 1f);
                }
                else if (hit.transform.tag == "info")
                {
                    // Handle displaying information about the celestial body, if needed
                }
            }
        }
    }

    public void nextButton()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        switch (UIState)
        {
            case "Mars":
                if (infoID == 1)
                {
                    infoID = 2;
                    infoBox.text = marsText2;
                    audioSource.PlayOneShot(Marsclip2, 1f);
                }
                break;
            case "Earth":
                if (infoID == 1)
                {
                    infoID = 2;
                    infoBox.text = earthText2;
                    audioSource.PlayOneShot(EarthClip2, 1f);
                }
                break;
            case "Venus":
                if (infoID == 1)
                {
                    infoID = 2;
                    infoBox.text = venusText2;
                    audioSource.PlayOneShot(VenusClip2, 1f);
                }
                break;
            case "Mercury":
                if (infoID == 1)
                {
                    infoID = 2;
                    infoBox.text = mercuryText2;
                    audioSource.PlayOneShot(MercuryClip2, 1f);
                }
                break;
            case "Sun":
                if (infoID == 1)
                {
                    infoID = 2;
                    infoBox.text = sunText2;
                    audioSource.PlayOneShot(SunClip2, 1f);
                }
                break;
            case "Moon":
                if (infoID == 1)
                {
                    infoID = 2;
                    infoBox.text = moonText2;
                    audioSource.PlayOneShot(MoonClip2, 1f);
                }
                break;

        }
    }
}
