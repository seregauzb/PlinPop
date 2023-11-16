using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easyrenderer : MonoBehaviour
{
    public GameObject g1,g2,g3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void easy(){
        g1.SetActive(true);
        g2.SetActive(false);g3.SetActive(false);

    }
    public void medium(){
        g1.SetActive(false);
        g2.SetActive(true);g3.SetActive(false);
    }
    public void hard(){
        g1.SetActive(false);
        g2.SetActive(false);g3.SetActive(true);
    }
}
