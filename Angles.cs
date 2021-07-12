using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Angles : MonoBehaviour
{
    private void Update()
    {
        GameObject.Find("txtAngle").GetComponent<Text>().text = GetAngles();
    }
    private void OnValidate()
    {
        GameObject.Find("txtAngle").GetComponent<Text>().text = GetAngles();
    }
    private void OnDrawGizmos()
    {
        // draw the lines in sceneview
        GameObject A = this.transform.Find("A").gameObject;
        GameObject B = this.transform.Find("B").gameObject;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, A.transform.position);
        Gizmos.DrawLine(this.transform.position, B.transform.position);
    }
    public string GetAngles()
    {
        // calculate the angle ACB
        GameObject A = this.transform.Find("A").gameObject;
        GameObject B = this.transform.Find("B").gameObject;

        Vector3 CA = this.transform.position - A.transform.position;
        Vector3 CB = this.transform.position - B.transform.position;

        float angle = Vector3.SignedAngle(CA, CB, Vector3.up);

        return angle.ToString();
    }
}
