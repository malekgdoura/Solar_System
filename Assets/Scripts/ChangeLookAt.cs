using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{

     public GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if(target == null)
       {
        target = this.gameObject;
        Debug.Log("change loog target is not specified. defqulting to parent object.");
       } 
    }

    // Update is called once per frame
    private void OnMouseDown () {
        Lookat.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);

    }
}
