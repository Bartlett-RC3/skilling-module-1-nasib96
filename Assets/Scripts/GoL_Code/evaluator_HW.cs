using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evaluator_HW : MonoBehaviour
{
    // Variables and refrences
    private GameObject caGrid;
    IEnumerator ageEvaluvator;
    private int recordLimit = 0;
    private int recordedState = 0;
    private Color VioletColour;

    // Use this for initialization
    void Start()
    {
        ageEvaluvator = _ageEvaluvator();
        recordLimit = GameObject.Find("caGrid").GetComponent<CA_History>().noStatesToRecord;
    }   

    // Update is called once per frame
    void Update()
    {
        findCaHistory();
        
        if (recordedState <= recordLimit + 1)
        {
            StartCoroutine(ageEvaluvator);
        }
        StopCoroutine(ageEvaluvator);
    }

    // Methods

    // Display age of cells
    public void DisplayAge()
    {
        // Compute the minimu age and maximum age
        float minVal = float.MaxValue;
        float maxVal = float.MinValue;

        //Debug.Log(caGrid.name);

        foreach (Transform child in caGrid.transform)
        {
            int ageOfCube = child.gameObject.GetComponent<CA_Cube>().GetAge();
            if (ageOfCube < minVal) minVal = ageOfCube;
            if (ageOfCube > maxVal) maxVal = ageOfCube;
        }

        //Assigning Color
        foreach (Transform child in caGrid.transform)
        {
            float VioletVal = Remap((float)child.gameObject.GetComponent<CA_Cube>().GetAge(), minVal, maxVal, 0.0f, 1.0f);
            Color VioletColour = new Color(VioletVal, 0, VioletVal);
            child.GetComponent<CA_Cube>().DisplayAge(VioletColour);
        }
    }

    private float Remap(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
    public void findCaHistory()
    {
        caGrid = GameObject.Find("caHistory");
    }

    IEnumerator _ageEvaluvator()
    {
        while (true)
        {
            //findCaHistory();
            DisplayAge();
            recordedState++;

            yield return gameObject;
        }
    }
}
