using UnityEngine;
using DG.Tweening;

public class Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Sequence s = DOTween.Sequence();

        s.Append(transform.DORotate(new Vector3(0,0, 360), 1f, RotateMode.LocalAxisAdd).SetLoops(-1).SetEase(Ease.Linear));
       s.Append( transform.DOScale(2, .5f).SetLoops(-2, LoopType.Yoyo));
        s.AppendCallback( () =>
        { 
        Destroy(gameObject);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
