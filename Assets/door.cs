using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private Animator animation;
    public bool state;
    private bool paststate= false;    
    // Start is called before the first frame update
    void Start()
    {
        animation= this.gameObject.GetComponent<Animator>();
        animation.SetBool("character_nearby",state);
    }
    public void changestate(bool newbool){
        state=newbool;
    }
    public bool getstate(){
        return state;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(state != paststate)
        {
            animation.SetBool("character_nearby",state);
            paststate= state;
        }
    }
}
