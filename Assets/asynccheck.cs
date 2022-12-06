using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asynccheck : MonoBehaviour
{
    private bool first=false;
    private bool second=false;
    public GameObject door;
    private door doorscript;
    // Start is called before the first frame update
    void Start()
    {
        doorscript = door.GetComponent<door>();
    }

    public void change(int id){
        if(id==1)
        {
            first=true;
        }
        else{
            second=true;
        }
if(first&& second)
        {
            doorscript.changestate(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
