using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class BackgroundParallax : MonoBehaviour
{
    [SerializeField] private float _parallaxSpeed;
    private RawImage _image;
    private float _imagePositionX;

    private void Start()
    {
        _image = GetComponent<RawImage>();
        _imagePositionX = _image.uvRect.x;
    }

    private void Update()
    {
        _imagePositionX += _parallaxSpeed * Time.deltaTime;

        if (_imagePositionX > 1)
            _imagePositionX = 0;

        _image.uvRect = new Rect(_imagePositionX, 0, _image.uvRect.height, _image.uvRect.width);
    }
}
