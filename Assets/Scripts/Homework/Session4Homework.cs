using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework : MonoBehaviour
{
    //Variables
    public GameObject columnPrefab;
    IEnumerator createPreFabsCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        createPreFabsCoroutine = DropPrefabs();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(createPreFabsCoroutine);
        Debug.Log(Time.time);
        if (Time.time > 10)
        {
            // Stop a specific coroutine
            StopCoroutine(createPreFabsCoroutine);

            // stop all Coroutine
            //StopAllCoroutines();
        }
    }

    //Coroutines
    IEnumerator DropPrefabs()
    {
        while (true)
        {
            //Action the coroutine (create and drop column)
            Vector3 dropPosition = new Vector3(Random.RandomRange(-5.0f, 12.0f),
                                                Random.RandomRange(-5.0f, 12.0f),
                                                Random.RandomRange(-5.0f, 12.0f));
            Quaternion dropRotation = new Quaternion(Random.RandomRange(0, 90), 
                                                     Random.RandomRange(0, 90), Random.RandomRange(0, 90), Random.RandomRange(0, 90));
            Instantiate(columnPrefab, dropPosition, dropRotation);
            yield return new WaitForSeconds(5);
        }
    }
}
