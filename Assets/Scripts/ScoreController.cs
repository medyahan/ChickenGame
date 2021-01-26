using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    //Animation anim;
    //public List<Animation> anims = new List<Animation>();

    //[SerializeField] private AnimationClip rotation;
    //[SerializeField] private AnimationClip destroying;

    private GameObject objectToRotate;
    private bool rotating ;

    private void Start()
    {
        objectToRotate = this.gameObject;
        //StartCoroutine(Rotate(new Vector3(0, 90, 0), 1));
    }
    private IEnumerator Rotate(Vector3 angles, float duration)
    {
        Quaternion startRotation = objectToRotate.transform.rotation;
        Quaternion endRotation = Quaternion.Euler(angles) * startRotation;
        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            objectToRotate.transform.rotation = Quaternion.Lerp(startRotation, endRotation, t / duration);
            yield return null;
        }
        objectToRotate.transform.rotation = endRotation;
    }

}
