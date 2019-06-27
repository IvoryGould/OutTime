using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public Transform waypoint1;
    public Transform waypoint2;

    public int waitTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Movement());

    }

    IEnumerator Movement() {

        transform.Translate(waypoint2.position);
        yield return new WaitForSeconds(waitTime);
        transform.Translate(waypoint1.position);

    }
}
