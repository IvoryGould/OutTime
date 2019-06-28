using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventTrigger : MonoBehaviour
{

    public bool isEndTrigger;

    [SerializeField]
    private GameObject actor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider trigger)
    {

        if (this.isEndTrigger)
        {

            SceneManager.LoadScene(0);

        }
        else {

            actor.GetComponent<Actor>().DoThing();

        }

    }

}
