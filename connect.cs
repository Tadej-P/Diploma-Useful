using UnityEngine;
using System.Collections;

public class connect : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;
    public float width = 0.1f;

    protected GameObject cylinder;
    protected Vector3 obj1Pos;
    protected Vector3 obj2Pos;

    // Use this for initialization
    void Start()
    {
        //createCylinder ( new Vector3(1, 1, 1), new Vector3(2, 2, 2), 0.1f);
        if (obj1 != null || obj2 != null)
        {
            obj1Pos = obj1.transform.position;
            obj2Pos = obj2.transform.position;
            createCylinder1(obj1Pos, obj2Pos, width);
        }
        else {
            print("obj1 or obj2 missing!");
        }
    }

    //temporary variables
    protected Vector3 CurntObj1Pos;
    protected Vector3 CurntObj2Pos;
    protected Vector3 LastObj1Pos;
    protected Vector3 LastObj2Pos;

    // Update is called once per frame
    void Update()
    {

        if (obj1 != null || obj2 != null)
        {
            CurntObj1Pos = obj1.transform.position;
            CurntObj2Pos = obj2.transform.position;
            if (CurntObj1Pos != LastObj1Pos || CurntObj2Pos != LastObj2Pos)
            {
                //Debug.Log("Moving");
                Destroy(cylinder);
                obj1Pos = obj1.transform.position;
                obj2Pos = obj2.transform.position;
                createCylinder1(obj1Pos, obj2Pos, width);
            }
            LastObj1Pos = CurntObj1Pos;
            LastObj2Pos = CurntObj2Pos;
        }
    }

    //create primitive type cylinder betwen two points
    private void createCylinder1(Vector3 start, Vector3 end, float width)
    {

        Vector3 offset = end - start;
        Vector3 scale = new Vector3(width, offset.magnitude / 2, width);
        Vector3 position = start + offset / 2;

        cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //cylinder.tag = "cylinder";
        cylinder.GetComponent<CapsuleCollider>().enabled = false;
        cylinder.transform.position = position;
        cylinder.transform.up = offset;
        cylinder.transform.localScale = scale;
    }
}
