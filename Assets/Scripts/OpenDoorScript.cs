using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenDoorScript : MonoBehaviour
{
    public GameObject layer;
    private bool cambio = true;
    private bool state = true;

    // Start is called before the first frame update
    void Start()
    {
      this.transform.localRotation = new Quaternion(-0.4f,0,0,0);
      

    }

    // Update is called once per frame
    void Update()
    {

      if((this.transform.localRotation.x>0.4f ||this.transform.localRotation.x<-0.3f) && !cambio)
      {

          // aquí se cambia
          state = !state;
        layer.SetActive(state);
          cambio = true;        
      }
      if(cambio && this.transform.localRotation.x>-0.2f && this.transform.localRotation.x<0.2f)
      {
        cambio = false;
        
      }

    }
}
