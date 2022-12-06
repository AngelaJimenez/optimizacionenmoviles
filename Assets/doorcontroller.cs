using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcontroller : MonoBehaviour
{
    public GameObject[] doors; 
    public GameObject[] spacesallowed;
    public GameObject current;
    private Animator[] animators;
    // Start is called before the first frame update
    void Start()
    {
        current= doors[0];
        for (int i = 0; i < doors.Length; i++)
        {
            animators[i]= doors[i].GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeto(int id)
    {
        
    }
}
