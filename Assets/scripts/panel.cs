using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class panel : MonoBehaviour
{
    public TMP_Text pult,t1,t2;
    public shar shar;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        t1.text=shar.pul.ToString();
        t2.text=shar.pul.ToString();
        pult.text=shar.pul.ToString();
    }
    public void openpanel(){
        pult.text=shar.pul.ToString();
    }
}
