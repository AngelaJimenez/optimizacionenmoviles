using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportmodification : MonoBehaviour
{

    public GameObject[] tps;
    public GameObject[] doors;
    public door[] doorcode;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < doors.Length; i++)
        {
            doorcode[i]=doors[i].GetComponent<door>();
        }
        check();
    }

    // Update is called once per frame
    void Update()
    {
        check();
    }

    public void check()
    {
        for (int i = 0; i < doorcode.Length; i++)
        {
            tps[i].SetActive(doorcode[i].getstate());
        }
    }
}
