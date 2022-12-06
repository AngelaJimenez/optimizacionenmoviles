using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class optimizationchoose : MonoBehaviour
{
        public UnityEvent onPress;
    public UnityEvent onRelease;
    private Vector3 firstPositionButton; 
    private bool isPressed;
    public GameObject button;
    public GameObject otherButton;
    private optimizationchoose otheroptimizationchoose;
    public GameObject door;
    private door doorcode; 
    // Start is called before the first frame update
    void Start()
    {
       
        isPressed= false;
        firstPositionButton=button.transform.localPosition;
        otheroptimizationchoose= otherButton.GetComponent<optimizationchoose>();
        doorcode = door.GetComponent<door>();
    }
    private void OnTriggerEnter(Collider other)
    {
                if(!isPressed)
        {
            Debug.Log("changes");
            button.transform.localPosition= firstPositionButton- new Vector3(0,0.02f,0);
            button.gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            onPress.Invoke();
            isPressed= true;
            doorcode.changestate(true);
            otheroptimizationchoose.unpressButton();
        }
    }
        public void unpressButton()
    {
        button.transform.localPosition= firstPositionButton;
        button.gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            doorcode.changestate(false);
        onRelease.Invoke();
            isPressed= false;

    }


}
