using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA_Cube_Class_2 : MonoBehaviour {

    // Variables
    private int state = 0;
    private int futureState = 0;
    public bool computed = false;

    //Added
    private float _colorValue;
    IEnumerator ageEvaluvator;
    private Color props;

    public void Start() // Added
    {
        ageEvaluvator = colorValue();
        //cellcurrentState = GameObject.Find("caGrid").GetComponent<CA_3D_Class_2>().;
    }
    // Update is called once per frame
    void Update () 
    {
        props = new Color (_colorValue, 0, _colorValue);// Added

        if (state >=1)  // Added
        {
            StartCoroutine(ageEvaluvator);
        }
        if (state == 0)  // Added
        {
            StopCoroutine(ageEvaluvator);
        }


        if(computed == false)
        {
            state = futureState;
            DisplayCube();
        } else 
        {
            DisplayCube();
        }
	}

    // Behaviours (Methods)

    // Sets the cube as being computed 
    public void SetComputed(bool _computed)
    {
        computed = _computed;
    }

    // Display behaviour
    void DisplayCube()
    {
        //MaterialPropertyBlock props = new MaterialPropertyBlock();-edited
        // MeshRenderer renderer; -edited
        // If the cell is dead do not show it
        if (state == 0){
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        } else {
            // Else show the cell
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            //props.SetColor("_Color", Color.white); -edited

            gameObject.GetComponent<MeshRenderer>().material.color = props; // Added
            //renderer = gameObject.GetComponent<MeshRenderer>();-edited
            //renderer.SetPropertyBlock(props); -edited
        }
    }

    // Method to set the futureState variable
    public void SetFutureState(int _futureState)
    {
        futureState = _futureState;
    }

    // Methods to set the current state variable
    public void SetState(int _state){
        state = _state;
    }

    // Help method to retreive what the current state is
    public int GetState(){
        return state;
    }

    // Help method to retrive what will be the future state
    public int GetFutureState(){
        return futureState;
    }

    // Method to rotate the cube
    public void RotateCube(){
        gameObject.transform.Rotate(new Vector3(0, 45, 0));
    }

    //Added
    IEnumerator colorValue()
    {
        while (true)
        {
            _colorValue =+ 0.7f;
            yield return _colorValue;
        }
    }

}
