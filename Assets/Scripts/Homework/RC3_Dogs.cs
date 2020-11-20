using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dog_Class;

public class RC3_Dogs : MonoBehaviour
{
    Dog_Class_RC3 terrier, akita, husky, malamute;
    public void Awake()
    {
        terrier = new Dog_Class_RC3("Terrier", 12);
        akita = new Dog_Class_RC3("Akita", 15);
        husky = new Dog_Class_RC3("Husk", 5);
        malamute = new Dog_Class_RC3("Malamute", 10);
    }
    // Start is called before the first frame update
    void Start()
    {
        akita.Bark();
        terrier.getHeight();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
