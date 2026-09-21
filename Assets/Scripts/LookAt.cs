using UnityEngine;

public class Lookat : MonoBehaviour
{

    static public GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject;
            Debug.Log("Look at target not specified. defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(target){
            transform.LookAt(target.transform);     
        }
    }
}
