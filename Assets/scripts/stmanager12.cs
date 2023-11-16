using System.Collections;
using System.Collections.Generic ;
using UnityEngine;
using UnityEngine.Purchasing;
using System.IO;
using TMPro;

public class stmanager12 : MonoBehaviour, IStoreListener
{
    private static IStoreController storeController;
    private static IExtensionProvider extensionProvider;
    // Replace "your_product_id" with the actual product ID
    string productID="50_coins",productID1="100_coins" ,productID2="3000_coins" ,productID3="4000_coins" ,productID4="10000_coins"  ;
    public shar knop;
    public AudioSource buying;
    float zagrsec=0;
    bool savdo,producta;
    public GameObject zfon,zag;
    public TMP_Text shoptext;
    int pul=0;

    void Start()
    {
        InitializePurchasing();
        shoptext.text=knop.pul.ToString();
        pul=pulochish(File.ReadAllText(Application.persistentDataPath + "/hayvonlar.txt"));
    }
    public void pulupdate(){
        shoptext.text=pul.ToString();
    }
    int pulochish(string s){
        char[] ch1=s.ToCharArray();
        string[] tillar=new string[9];
        byte dt=0,sanoq=0;
        string soz="";
        string javob="";
        foreach(var a in ch1){
            if(a.ToString()!="|"){
            soz+=a.ToString();dt++;
            }else{
                dt=0;tillar[sanoq]=soz;sanoq++;soz="";
            }
        }
        while(sanoq>0){
            sanoq--;
            s=tillar[sanoq];
        if(s=="ciklop"){
            javob+="0";
        }
        if(s=="tiger"){
            javob+="1";
        }
        if(s=="elephand"){
            javob+="2";
        }
        if(s=="duck"){
            javob+="3";
        }
        if(s=="sheep"){
            javob+="4";
        }
        if(s=="wolf"){
            javob+="5";
        }
        if(s=="hyena"){
            javob+="6";
        }
        if(s=="coyote"){
            javob+="7";
        }
        if(s=="zebra"){
            javob+="8";
        }
        if(s=="buffalo"){
            javob+="9";
        }
        Debug.Log(javob);
        }
        soz="";
        ch1=javob.ToCharArray();
        Debug.Log(javob);
        foreach(var a in ch1){
            soz=a.ToString()+soz;
        }
        return int.Parse(soz);
    }
    void Update(){
        pul=knop.pul;
        if(savdo){
            savdo=false;
            if(producta){
                    PurchaseProduct1();
                }else{
                PurchaseProduct();
                }
        }
    }
    private void Add1000Coins()
    {
        pul+= 1000;
        pulkodlash();
        buyingf();
        File.WriteAllText(Application.persistentDataPath + "/sherali.txt","yoshligimiz");
        shoptext.text=pul.ToString();
    }
    private void Add2000Coins()
    {
        pul += 5000;
        pulkodlash();
        buyingf();
        File.WriteAllText(Application.persistentDataPath + "/sherali.txt","yoshligimiz");
        shoptext.text=pul.ToString();
    }
    private void Add3000Coins()
    {
        pul += 10000;
        pulkodlash();
        buyingf();
        File.WriteAllText(Application.persistentDataPath + "/sherali.txt","yoshligimiz");
        shoptext.text=pul.ToString();
    }
    private void Add4000Coins()
    {
        pul += 20000;
        pulkodlash();
        buyingf();
        File.WriteAllText(Application.persistentDataPath + "/sherali.txt","yoshligimiz");
        shoptext.text=pul.ToString();
    }
    public void buyingf(){
        knop.pul=pul;
        knop.pultext.text=pul.ToString();
        Destroy(Instantiate(buying,transform.position,transform.rotation),5);
        //knop.buycomp.SetActive(true);
        ///knop.buyfield.SetActive(false);
        //knop.sanoq1=3;
    }
    public void InitializePurchasing()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        // Add your product ID to the builder
        builder.AddProduct(productID, ProductType.NonConsumable);
        builder.AddProduct(productID1, ProductType.NonConsumable);
        builder.AddProduct(productID2, ProductType.NonConsumable);
        builder.AddProduct(productID3, ProductType.NonConsumable);
        builder.AddProduct(productID4, ProductType.NonConsumable);

        UnityPurchasing.Initialize(this, builder);
    }
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        
        storeController = controller;
        extensionProvider = extensions;
    }
    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("Initialization failed: " + error);
    }
    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        Debug.LogError("Initialization failed: " + error + ", " + message);
    }
    public void PurchaseProduct1()
    {
        if (storeController != null)
        {
            Product product1 = storeController.products.WithID(productID1);

            if (product1 != null && product1.availableToPurchase)
            {
                storeController.InitiatePurchase(product1);
                
            }
            else
            {
                Debug.Log("Product not available for purchase.");
            }
        }
        else
        {
            Debug.Log("Store controller is not initialized.");
        }
    }
    public void PurchaseProduct2()
    {
        if (storeController != null)
        {
            Product product2 = storeController.products.WithID(productID1);

            if (product2 != null && product2.availableToPurchase)
            {
                storeController.InitiatePurchase(product2);
                
            }
            else
            {
                Debug.Log("Product not available for purchase.");
            }
        }
        else
        {
            Debug.Log("Store controller is not initialized.");
        }
    }
    public void PurchaseProduct3()
    {
        if (storeController != null)
        {
            Product product3 = storeController.products.WithID(productID3);

            if (product3 != null && product3.availableToPurchase)
            {
                storeController.InitiatePurchase(product3);
                
            }
            else
            {
                Debug.Log("Product not available for purchase.");
            }
        }
        else
        {
            Debug.Log("Store controller is not initialized.");
        }
    }
    public void PurchaseProduct4()
    {
        if (storeController != null)
        {
            Product product4 = storeController.products.WithID(productID4);

            if (product4 != null && product4.availableToPurchase)
            {
                storeController.InitiatePurchase(product4);
                
            }
            else
            {
                Debug.Log("Product not available for purchase.");
            }
        }
        else
        {
            Debug.Log("Store controller is not initialized.");
        }
    }
    public void PurchaseProduct()
    {
        if (storeController != null)
        {
            Product product = storeController.products.WithID(productID);

            if (product != null && product.availableToPurchase)
            {
                storeController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("Product not available for purchase.");
            }
        }
        else
        {
            Debug.Log("Store controller is not initialized.");
        }
    }
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        zfon.SetActive(false);
            zag.SetActive(false);
        Debug.Log("Purchase successful: " + args.purchasedProduct.definition.id);
        if(productID=="50_coins"){
            Add1000Coins();
        }
        if(productID=="100_coins"){
            Add2000Coins();
        }
        if(productID=="3000"){
            Add3000Coins();
        }
        if(productID=="4000"){
            Add4000Coins();
        }
        // Add your logic for handling the successful purchase here

        return PurchaseProcessingResult.Complete;
    }
    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        zfon.SetActive(false);
            zag.SetActive(false);
        Debug.Log("Purchase failed: " + failureReason);
        // Add your logic for handling the failed purchase here
    }
    public void BUYN1(){
        savdo=true;
        productID="50_coins";
        zagrsec=2;
        zfon.SetActive(true);
        zag.SetActive(true);producta=false;
    }
    public void BUYN2(){
        productID="100_coins";
        zagrsec=2;
        savdo=true;
        zfon.SetActive(true);
        zag.SetActive(true);
        producta=true;
    }
    public void BUYN3(){
        productID="3000";
        zagrsec=2;
        savdo=true;
        zfon.SetActive(true);
        zag.SetActive(true);
        producta=true;
    }
    public void BUYN4(){
        productID="4000";
        zagrsec=2;
        savdo=true;
        zfon.SetActive(true);
        zag.SetActive(true);
        producta=true;
    }
    public void BUYN5(){
        productID="10000_coins";
        zagrsec=2;
        savdo=true;
        zfon.SetActive(true);
        zag.SetActive(true);
        producta=true;
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
}