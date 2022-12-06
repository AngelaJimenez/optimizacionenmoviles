using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datacheck : MonoBehaviour
{
    public string name;
    public GameObject newserver;
    public GameObject thisserver;
    public GameObject internet;
    private internetfeedback internetfeedback;
    // Start is called before the first frame update
    void Start()
    {
        internetfeedback= internet.GetComponent<internetfeedback>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        
            if(other.gameObject.tag=="data" && other.gameObject.name==name && internetfeedback.internetstatus())
            {
                other.gameObject.SetActive(false);
                newserver.gameObject.SetActive(true);
                thisserver.gameObject.SetActive(false);
            }
        
    }
}
