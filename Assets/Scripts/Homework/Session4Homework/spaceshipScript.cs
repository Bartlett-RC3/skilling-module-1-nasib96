using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipScript : MonoBehaviour
{
    // Variables

    private Color obstacleColorChange = new Color(1, 1, 1);
    IEnumerator colourchangeCoroutine;
    private int startValue = 0;
    public UnityEngine.UI.Text startGame;
   

    // Start is called before the first frame update
    void Start()
    {
        // Game begning
        startGame.text = " Hit RETURN to Choose the colour and Play ";
        colourchangeCoroutine = colourchange();
        StartCoroutine(colourchangeCoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        // Spaceship colour
        this.gameObject.GetComponent<MeshRenderer>().material.color = obstacleColorChange;

        // rotate
        Vector3 rotateCopy = new Vector3(Time.time, 0, 0);
        this.gameObject.transform.Rotate(rotateCopy, Space.World);

        // Fix a Colour
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StopCoroutine(colourchangeCoroutine);
            startValue = +1;
            startGame.text = "";
        }

        // Start game
        if (startValue == 1)
        {
            // Move UP
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                this.gameObject.transform.Translate(Vector3.up * 1.0f, Space.World);
            }
            // Move DN
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                this.gameObject.transform.Translate(Vector3.down * 1.0f, Space.World);
            }

            // Move forward 
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime);
        }
    }

    // Coroutine for colour change
    IEnumerator colourchange()
    {
        while (true)
        {
            obstacleColorChange = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            yield return new WaitForSeconds(3);
        }
    }

}
