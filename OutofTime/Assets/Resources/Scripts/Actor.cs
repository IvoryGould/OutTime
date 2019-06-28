using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{

    public enum ACTORTYPE {

        Gate,
        Collectable

    }

    public ACTORTYPE ActorTypes;

    [Header("Gate")]
    [SerializeField]
    private Transform gateWaypoint;

    [Header("Collectable")]
    [SerializeField]
    private int collectValue;

    [SerializeField]
    private Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    public void DoThing() {

        if (ActorTypes == ACTORTYPE.Gate)
        {
            
            StartCoroutine(OpenGate());

        }
        else if (ActorTypes == ACTORTYPE.Collectable)
        {

            Collect();

        }

    }

    IEnumerator OpenGate() {

        while (this.transform.position != gateWaypoint.position) {

            this.transform.Translate((gateWaypoint.position - this.transform.position) * Time.deltaTime);
            yield return new WaitForEndOfFrame();

        }

    }

    void Collect() {

        timer.time += collectValue;
        Destroy(this.gameObject);

    }

}
