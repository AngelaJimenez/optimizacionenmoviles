using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class gearatach : MonoBehaviour
{
        public string taggear;
        private GameObject foundIt;
        public GameObject keyHolder;
        public GameObject me;
        public Vector3 position =  new Vector3(-13.063f,0.989f, -10.483f);
        public GameObject pointer;
        public bool positioned=false;

 void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(taggear)){
        foundIt= collision.gameObject;
        
}

    }

 public void check() {

       
        if (foundIt && !positioned)
    {
           
         Rigidbody m_Rigidbody= foundIt.GetComponent< Rigidbody>();
         foundIt.transform.position=position;
         m_Rigidbody.useGravity = false;
         foundIt.transform.rotation= Quaternion.Euler(new Vector3(0, 180, 0));
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ |  RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationX;
        keyHolder.SetActive(false);
        me.SetActive(false);
        Gearmove script= foundIt.AddComponent<Gearmove>();
        script.pointer= pointer;
        positioned=true;
    }
}
 
  void Update() {
 if (foundIt && !positioned)
    {
           
         Rigidbody m_Rigidbody= foundIt.GetComponent< Rigidbody>();
         foundIt.transform.position=position;
         m_Rigidbody.useGravity = false;
         foundIt.transform.rotation= Quaternion.Euler(new Vector3(0, 180, 0));
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ |  RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationX;
        keyHolder.SetActive(false);
        me.SetActive(false);
        Gearmove script= foundIt.AddComponent<Gearmove>();
        script.pointer= pointer;
        positioned=true;
    }   
 }

  
}