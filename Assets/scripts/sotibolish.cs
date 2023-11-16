using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class sotibolish : MonoBehaviour
{
    public GameObject set,aslo;
    public int narx=1000,ish=0;
    int pul;
    public TMP_Text pult;
    bool olingan=false,topilmadi=true;
    public shar shar;
    public knopka knop;
    public string manzil="/qunduz.txt";
    public RawImage naxt;
    public Texture sell;
    bool sharcha;
    public bool  top=true;
    string m2222="";

    // Start is called before the first frame update
    void Start()
    {
        if(top){
            m2222="/maqol3.txt";
        }else{
            m2222="/maqol3a.txt";
        }
        if(shar==null){
            pul=knop.pul;
            sharcha=false;
        }else{
            pul=shar.pul;
            sharcha=true;
        }
        pult.text=pul.ToString();
        if(File.ReadAllText(Application.persistentDataPath + manzil)!="0"){
            olingan=true;
            naxt.texture=sell;
            if(File.ReadAllText(Application.persistentDataPath + manzil)=="france"){
                set.SetActive(true);
            }else{
                set.SetActive(false);
            }
        }
        topilmadi=false;

    }

    // Update is called once per frame
    void Update()
    {
        if(sharcha){
            pul=shar.pul;
        }else{
            pul=knop.pul;
        }
        if(topilmadi){
            File.WriteAllText(Application.persistentDataPath + manzil,"0");
        }
        pult.text=pul.ToString();
    }
    public void ketti(){
        if(pul>=narx&&olingan==false){
            olingan=true;
            pul-=narx;
            File.WriteAllText(Application.persistentDataPath + manzil,"france2");
            pulkodlash();
            naxt.texture=sell;
        }
        if(pul<narx&&olingan==false){
            aslo.SetActive(true);
        }
        if(sharcha){
            shar.pultext.text=pul.ToString();
            shar.pul=pul;
        }else{
            //knop.pultext.text=pul.ToString();
            knop.pul=pul;
        }
        pult.text=pul.ToString();
        if(olingan){
            tanlandi();
        }
    }
    public void pulkodlash(){
        string soz="";string son=pul.ToString();
        char[] ch1=son.ToCharArray();
        foreach(var v in ch1){
            
            switch(int.Parse(v.ToString())){
                case 0:soz+="ciklop";break;
                case 1:soz+="tiger";break;
                case 2:soz+="elephand";break;
                case 3:soz+="duck";break;
                case 4:soz+="sheep";break;
                case 5:soz+="wolf";break;
                case 6:soz+="hyena";break;
                case 7:soz+="coyote";break;
                case 8:soz+="zebra";break;
                case 9:soz+="buffalo";break;
            }
            soz+="|";
        }
        File.WriteAllText(Application.persistentDataPath + "/hayvonlar.txt",soz);
    }
    public void tanlanmadi(){
        set.SetActive(false);
        if(olingan){
            File.WriteAllText(Application.persistentDataPath + manzil,"france2");
        }else{
            File.WriteAllText(Application.persistentDataPath + manzil,"0");
        }
    }
    public void tanlandi(){
        Debug.Log("c");
        set.SetActive(true);
        File.WriteAllText(Application.persistentDataPath + m2222,ish.ToString());
        File.WriteAllText(Application.persistentDataPath + manzil,"france3");
        if(top){
            shar.bolnum=(byte)ish;
            shar.setimage();
        }else{
            shar.setfayld();
        }
    }
}
