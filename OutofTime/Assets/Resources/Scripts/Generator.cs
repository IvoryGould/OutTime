using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    List<Platform> spawnedPlatforms = new List<Platform>();
    GameObject platform1;
    GameObject platform2;
    GameObject platform3;
    GameObject blankPlatform;

    private void Awake()
    {

        platform1 = Resources.Load<GameObject>("platform1");
        platform2 = Resources.Load<GameObject>("platform2");
        platform3 = Resources.Load<GameObject>("platform3");
        blankPlatform = Resources.Load<GameObject>("platformBlank");

    }

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 6; i++) {

            spawnedPlatforms.Add(Instantiate<GameObject>(blankPlatform).GetComponent<Platform>());
            if (!spawnedPlatforms[0]) {

                float currentPosition = spawnedPlatforms[i].transform.position.z;

                currentPosition = spawnedPlatforms[i - 1].transform.position.z * 2;

            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
