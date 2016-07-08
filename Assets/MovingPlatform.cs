using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {
    private GameObject target = null;

	void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Player"))
        {
            if (target == null)
            {
                target = col.gameObject;
                target.transform.SetParent(transform);
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (target == col.gameObject)
            {
                target.transform.SetParent(null);
                target = null;
            }
        }
    }
}
