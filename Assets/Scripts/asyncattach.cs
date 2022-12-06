using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class asyncattach : MonoBehaviour
{
        public string taggear;
        public string name;
        public int id;
        public GameObject me;
        public Vector3 position =  new Vector3(-13.063f,0.989f, -10.483f);
        public asynccheck asynccheck;

 void OnCollisionEnter(Collision collision)
    {
        Debug.Log("entered");
        if(collision.gameObject.CompareTag(taggear) && collision.gameObject.name==name ){
        GameObject foundIt= collision.gameObject;
                 Rigidbody m_Rigidbody= foundIt.GetComponent< Rigidbody>();
         foundIt.transform.position=position;
         m_Rigidbody.useGravity = false;
                  foundIt.gameObject.isStatic = true;
         foundIt.transform.rotation= Quaternion.Euler(new Vector3(90,-90,-90));
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ |  RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX |RigidbodyConstraints.FreezeRotationY|RigidbodyConstraints.FreezeRotationX;
            me.SetActive(false);
            asynccheck.change(id);
        }

    }



  
}