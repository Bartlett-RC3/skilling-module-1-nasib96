using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{
    // Variables
    public GameObject cube;
    public int numberOfCubes = 7;
    public int spacing = 5;
    private List<GameObject> cubeCopies = new List<GameObject>();
    private readonly List<GameObject> homeWorkCubes = new List<GameObject>();
    private int frameCount = 0;
    public GameObject rc3Cube ;
    public int posX = 0;




    private void Awake()
    {

        
        

    }

    // Start is called before the first frame update
    void Start()
    {
        // framerate change
        UnityEngine.Application.targetFrameRate = 10;

        for (int i=0; i<numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(i * spacing, 0, 0);
            Quaternion cubeCopyRotation = Quaternion.identity;
            GameObject cubeCopy = Instantiate(cube, cubeCopyPosition, cubeCopyRotation);
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
            cubeCopies.Add(cubeCopy);
        }

        //Homework
        GameObject rc3Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rc3Cube.transform.position = new Vector3(posX, 3, 0);
        homeWorkCubes.Add(rc3Cube);

    }

    // Update is called once per frame
    void Update()
    {
       for(int i =0; i<cubeCopies.Count; i++)
        {
            GameObject cubeCopy = cubeCopies[i];
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
        }

        // Time since game started
        Debug.Log(" Frames :" + frameCount);
        frameCount++;

        Debug.Log("Unity counted frames :" + Time.frameCount);
        Debug.Log("Unity draws a frame in :" + Time.deltaTime + "s");

        // Moving
        foreach (GameObject cubeCopy in cubeCopies)
        {
            // translate 
            Vector3 moveCopy = new Vector3(0, Random.Range(-2.0f, 2.0f), 0);
            cubeCopy.GetComponent<Transform>().Translate(moveCopy * Time.deltaTime);

            // rotate
            Vector3 rotateCopy = new Vector3(0, Random.Range(-90.0f, 90.0f), 0);
            cubeCopy.transform.Rotate(rotateCopy);

            // scale
            float scaleAmount = Random.Range(0.5f, 2.0f);
            Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            cubeCopy.transform.localScale = scaleCopy;

        }

        // Homewwork
        foreach (GameObject rc3Cube in homeWorkCubes)
        {
            if (rc3Cube.transform.position.x <=30)
            {
                /* test 1 
                Vector3 hwMove = new Vector3(1, 0, 0);
                rc3Cube.GetComponent<Transform>().Translate(hwMove * Time.deltaTime);
                test 2
                float newPosX = rc3Cube.transform.position.x + 1;
                rc3Cube.transform.position = new Vector3(newPosX, 3, 0);
                */
                rc3Cube.transform.Translate(Vector3.right * Time.deltaTime);
                Color rc3CubeColor = new Color(1, 0, 0);
                rc3Cube.GetComponent<MeshRenderer>().material.color = rc3CubeColor;

            }
            else
            {
                float newPosX = rc3Cube.transform.position.x * 0;
                rc3Cube.transform.position = new Vector3(newPosX, 3, 0);
                Color rc3CubeColor = new Color(1, 0, 0);
                rc3Cube.GetComponent<MeshRenderer>().material.color = rc3CubeColor;
            }
            // translate 
            Vector3 moveCopy = new Vector3(0, Random.Range(-2.0f, 2.0f), 0);
            rc3Cube.GetComponent<Transform>().Translate(moveCopy * Time.deltaTime);

            /*// rotate
            Vector3 rotateCopy = new Vector3(0, Random.Range(-90.0f, 90.0f), 0);
            cubeCopy.transform.Rotate(rotateCopy);

            // scale
            float scaleAmount = Random.Range(0.5f, 2.0f);
            Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            cubeCopy.transform.localScale = scaleCopy;*/

        }




        // Keyboard input
        if (Input.GetKey(KeyCode.Space))
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                // Fixed scale
                float scaleAmount = 1.5f;
                Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
                cubeCopy.transform.localScale = scaleCopy;
            }

            // Homework
            foreach (GameObject rc3Cube in homeWorkCubes)
            {
                // move up
                float newPosY = rc3Cube.transform.position.y + 1;
                rc3Cube.transform.position = new Vector3(rc3Cube.transform.position.x, newPosY, 0);

                //change colour while moving up
                Color hwCubeUp = new Color(1, 0, 2);
                rc3Cube.GetComponent<MeshRenderer>().material.color = hwCubeUp;
            }

        }

        if (Input.GetMouseButton(0))
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                // Fixed rotation
                Vector3 rotateCopy = new Vector3(10, 0, 0);
                cubeCopy.transform.Rotate(rotateCopy);
            }

            // Homework
            foreach (GameObject rc3Cube in homeWorkCubes)
            {
                // move down
                float newPosY = rc3Cube.transform.position.y -1;
                rc3Cube.transform.position = new Vector3(rc3Cube.transform.position.x, newPosY, 0);

                // change colour while moving down
                Color hwCubeDn = new Color(1, 2, 0);
                rc3Cube.GetComponent<MeshRenderer>().material.color = hwCubeDn;
            }
        }
    }
}
