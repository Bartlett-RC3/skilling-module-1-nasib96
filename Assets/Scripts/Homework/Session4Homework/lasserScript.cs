using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasserScript : MonoBehaviour
{
    // Variable
    public GameObject[] obstacles = new GameObject[3];
    public int spacing = 2;
    public UnityEngine.UI.Text gameEnd;
    private int obstaclesCount;

    // Start is called before the first frame update
    void Start()
    {
        obstaclesCount = obstacles.Length;

        // framerate change
        UnityEngine.Application.targetFrameRate = 30;

        // Construction of obstacles array
        for (int i = 0; i < obstacles.Length; i++)
        {
            Vector3 obstaclePosition = new Vector3(Random.Range (20, 30), Random.Range(-14, 15), 0);
            GameObject createObstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            createObstacle.transform.position = obstaclePosition;
            Quaternion obstacleRotation = Quaternion.identity;
            GameObject _obstacle = Instantiate(createObstacle, obstaclePosition, obstacleRotation);
            _obstacle.GetComponent<MeshRenderer>().material.color = new Color(0.0f, Random.Range(0.0f, 1.0f), 0.5f);
            obstacles[i] = _obstacle;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // For Shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;

            // position from where we are casting the ray
            Vector3 rayCastPosition = this.gameObject.transform.position;

            //the position from where we are casting the ray
            Vector3 rayCastDirection = this.gameObject.transform.TransformDirection(Vector3.down);

            // create a variable that stores the information about the hitting object
            RaycastHit objectSeenByRay;

            //Cast the ray
            if (Physics.Raycast(rayCastPosition, rayCastDirection, out objectSeenByRay))
            {
                Destroy(objectSeenByRay.transform.gameObject);

                obstaclesCount = obstaclesCount - 1;
            }
        }
        else
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }


        if (this.gameObject.transform.position.x > 31)
        {
            if (obstaclesCount <= (obstacles.Length/2))
            {
                gameEnd.text = " You Win! ";
            }
            else
            {
                gameEnd.text = " You Lose! ";
            }
        }
        else
        {
            gameEnd.text = "";
        }









    }
}
