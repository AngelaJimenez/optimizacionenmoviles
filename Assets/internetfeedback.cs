using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 
public class internetfeedback : MonoBehaviour
{
    public bool internet = true;

    public GameObject[] toRedNoInternet;
    public GameObject[] toRedNoData;
    public Material bad;
    public Material good;
    public Material perfect;
    public GameObject[] servers;
    private bool currentInternet = true;
    private bool data=false;
    // Start is called before the first frame update
    void Start()
    {
            checkData();
            changeInternet(internet);

    }
    public bool internetstatus(){
        return currentInternet;
    }
    private void changeInternet(bool state){
        Material tochange = bad;
        if(state && data)
        {
            tochange = perfect;
        }
        else if(state)
        {
            tochange = good;
        }
        
        for (int i = 0; i < toRedNoInternet.Length; i++)
            {
                toRedNoInternet[i].GetComponent<MeshRenderer>().material = tochange;

            }
            
    }
    private void checkData(){
        bool allactive=true;
        Material tochange = bad;
        bool lights= true; 
        for (int i = 0; i < servers.Length && allactive; i++)
        {
            allactive = servers[i].activeSelf;
        }
        data= allactive;
        if(data && currentInternet){
            tochange=perfect;
            lights= false; 
        }
        else if(data|| currentInternet){
            lights= false; 
          tochange= good;
        }
        for (int i = 0; i < toRedNoData.Length; i++)
            {
                toRedNoData[i].GetComponent<MeshRenderer>().material = tochange;
                if(i>0)
                {
                     toRedNoData[i].GetComponent<Light>().enabled= lights;
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        checkData();
        if(internet!=currentInternet )
        {
            currentInternet=internet;
            
        }
            changeInternet(internet);
    }
}
