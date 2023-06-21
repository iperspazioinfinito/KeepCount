using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControllers : MonoBehaviour
{
    public int minSayi = 1;
    public int maxSayi = 100;
    public int tahmin;
    public bool bitis;
    
    void Start()
    {
        print("Kafandan 1-100 arasýnda sayi tutmak ister misin? (E/H)");
        bitis = true;
    }

    void Update()
    {

        /* ------------------Menu---------------------*/
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Harika! Simdi Devam etmek icin yukari ya da asagý yon tusuna bas");
            bitis = false;
        }
            
        else if (Input.GetKeyDown(KeyCode.H) && bitis == true)
        {
            print("Yazik oldu.");
            bitis =true;
            Start();
        }
        /* ------------------Oyun baþlangýç---------------------*/
        if (Input.GetKeyDown(KeyCode.UpArrow) && bitis == false)
        {
            minSayi = tahmin;
            tahminiSayi();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && bitis == false)
        {
            maxSayi = tahmin;
            tahminiSayi();
        }
        /* ------------------Oyun sonu---------------------*/
        if (Input.GetKeyDown(KeyCode.Space) && bitis == false)
        {
            print("Bu sporu yapýyorum kabul et.");
            print("Tekrar oynamak istiyorsan (R) tusuna bas!");
            bitis = true;
            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            Start();
        }

    }
    void tahminiSayi()
    {
        tahmin =(minSayi+maxSayi) / 2;
        print("Aklindan gecen sayi yoksa " + tahmin + " olabilir mi? Dogruysa bosluk Tusuna bas, Yanlis ise yukari ya da asagý yon tusuna bas");
    }
}
