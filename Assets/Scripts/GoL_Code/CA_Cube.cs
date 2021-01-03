using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA_Cube : MonoBehaviour {

    // Variables
    private int state = 0;
    private int futureState = 0;
    public int CubeAge = 0;
    public bool updateState = true; //edited

    // Update is called once per frame
    void Update ()
    /*{
        state = futureState;
        DisplayCube();
    }*/
    {
        if (updateState)
        {
            state = futureState;
            DisplayCube();
        }
    }

    // Display the cube
    void DisplayCube()
    {
        MaterialPropertyBlock props = new MaterialPropertyBlock();
        MeshRenderer renderer;
        if (state == 0)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (state == 1)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            props.SetColor("_Color", Color.black);

            renderer = gameObject.GetComponent<MeshRenderer>();
            renderer.SetPropertyBlock(props);
        }
    }

    // For time spend alive
    public void DisplayAge(Color _cubeColor)
    {
        // Set the material property block to a colur assigned by the evaluator
        MaterialPropertyBlock props = new MaterialPropertyBlock();
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        props.SetColor("_Color", _cubeColor);

        // Update the colour of the mesh
        MeshRenderer renderer;
        renderer = gameObject.GetComponent<MeshRenderer>();
        renderer.SetPropertyBlock(props);
    }

    public void SetFutureState(int _futureState)
    {
        futureState = _futureState;
    }

    public void SetState(int _state)
    {
        futureState = _state;
    }

    public int GetState()
    {
        return state;
    }

    public int GetFutureState()
    {
        //return state;
        return futureState;
    }

    // For time spend alive
    public int GetAge()
    {
        return CubeAge;
    }

    public void SetAge(int _CubeAge)
    {
        CubeAge = _CubeAge;
    }

}
