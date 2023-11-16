using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class missiylar : MonoBehaviour
{
    public knopka knop;
    public byte narxi=1;
    public AudioSource buying;
    // Start is called before the first frame update
    void Start()
    {
        switch(narxi){
                case 1:if(File.ReadAllText(Application.persistentDataPath + "/missiya1.txt")=="lola"){gameObject.SetActive(false);};break;
                case 2:if(File.ReadAllText(Application.persistentDataPath + "/missiya2.txt")=="lola"){gameObject.SetActive(false);};break;
                case 3:if(File.ReadAllText(Application.persistentDataPath + "/missiya3.txt")=="lola"){gameObject.SetActive(false);};break;
                case 4:if(File.ReadAllText(Application.persistentDataPath + "/missiya4.txt")=="lola"){gameObject.SetActive(false);};break;
                case 5:if(File.ReadAllText(Application.persistentDataPath + "/missiya5.txt")=="lola"){gameObject.SetActive(false);};break;
                case 6:if(File.ReadAllText(Application.persistentDataPath + "/missiya6.txt")=="lola"){gameObject.SetActive(false);};break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ezilish(){
        if(knop.pul>=narxi*1000){
            knop.pul -= narxi*1000;
            knop.pulkodlash();
            switch(narxi){
                case 1:File.WriteAllText(Application.persistentDataPath + "/missiya1.txt","lola");break;
                case 2:File.WriteAllText(Application.persistentDataPath + "/missiya2.txt","lola");break;
                case 3:File.WriteAllText(Application.persistentDataPath + "/missiya3.txt","lola");break;
                case 4:File.WriteAllText(Application.persistentDataPath + "/missiya4.txt","lola");break;
                case 5:File.WriteAllText(Application.persistentDataPath + "/missiya5.txt","lola");break;
                case 6:File.WriteAllText(Application.persistentDataPath + "/missiya6.txt","lola");break;
            }
            gameObject.SetActive(false);
            knop.saralash();
            buyingf();
        }else{
            buyfieldf();
        }
    }
    public void buyingf(){
        Destroy(Instantiate(buying,transform.position,Quaternion.identity),5);
        knop.buycomp.SetActive(true);
        knop.sanoq1=3;
    }
    public void buyfieldf(){
        knop.buyfield.SetActive(true);
        knop.sanoq1=3;
    }
}
