using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class touch : MonoBehaviour
{
    public TMP_Text infoBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button");

            Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray,out hit, 100))
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name +":" + hit.transform.tag);

                if(hit.transform.tag == "mars")
                {
                   infoBox.text = "MARS \nLet's go visit";
                }

                if(hit.transform.tag == "earth")
                {
                   infoBox.text = "EARTH \n It's Our Home";
                }

                if(hit.transform.tag == "mercury")
                {
                   infoBox.text = "MERCURY \n I am the smallest";
                }

                if(hit.transform.tag == "venus")
                {
                   infoBox.text = "VENUS \n Second planet from the sun";
                }

                if(hit.transform.tag == "sun")
                {
                   infoBox.text = "SUN \nI am a star";
                }

                  if(hit.transform.tag == "moon")
                {
                   infoBox.text = "MOON \nI am Earth's only natural satellite";
                }
            }
        }
    }
}
