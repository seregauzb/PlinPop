using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class musicrend : MonoBehaviour
{
    bool muzyon=true,ovyoq=true;
    public AudioSource buying;
    public string manzil,javob;
    public RawImage switcher;
    public Texture texture,texturenot;
    bool yoniq=true,portlash=true;

    // Start is called before the first frame update
    void Start()
    {
        if(File.ReadAllText(Application.persistentDataPath + manzil)==javob){
            buying.volume=float.Parse(javob);
            switcher.texture=texture;
            yoniq=true;
            portlash=false;
        }else{
            buying.volume=0;
            switcher.texture=texturenot;
            yoniq=false;
            portlash=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(portlash){
            Destroy(gameObject);
        }
    }
    public void musicrender(){
        if(yoniq){
            buying.volume=0;
            switcher.texture=texturenot;
            yoniq=false;
            File.WriteAllText(Application.persistentDataPath + manzil,"0");
        }else{
            buying.volume=float.Parse(javob);
            switcher.texture=texture;
            yoniq=true;
            File.WriteAllText(Application.persistentDataPath + manzil,javob);
        }
    }
}
