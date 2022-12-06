using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkoverwritting : MonoBehaviour
{
    public GameObject[] activewhenworks;
    public GameObject[] shouldbedeactive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool state=true;
        for (int i = 0; i < shouldbedeactive.Length && state; i++)
        {
            if(shouldbedeactive[i].activeSelf)
            {
                state=false;
            }
        }
        if(!state){
            for (int i = 0; i < activewhenworks.Length; i++)
            {
                activewhenworks[i].SetActive(false);
            }
        }
        else{
            for (int i = 0; i < activewhenworks.Length; i++)
            {
                activewhenworks[i].SetActive(true);
                
            }
        }
    }
}
