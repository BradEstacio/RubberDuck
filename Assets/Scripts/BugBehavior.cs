using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugBehavior : MonoBehaviour
{
    public GameObject bug;
    public GameObject quacked;

    // For timing between "Bug" (enemy) and "Quacked" (functional object) state
    public float lastCompletedCycleTime;

    void Awake()
    {
        lastCompletedCycleTime = Time.time;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Bug is temporarily transformed into an object that can be used by the player
    public void QuackState(string bugName, float interval)
    {
        StartCoroutine(TransformTimer(interval));
    }

    public IEnumerator TransformTimer(float timer)
    {
        bug.gameObject.SetActive(false);
        quacked.gameObject.SetActive(true);
        yield return new WaitForSeconds(timer);
        bug.gameObject.SetActive(true);
        quacked.gameObject.SetActive(false);
    }
}