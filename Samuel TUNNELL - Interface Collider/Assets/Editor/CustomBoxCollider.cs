using UnityEngine;

[SerializeField]
public class CustomBoxCollider : MonoBehaviour
{
    public BoxCollider _boxCollider;
    public Vector3 _size;

    public Vector3 _center;

    public bool _isTrigger;

    public PhysicMaterial _physMaterial;

    void Awake()
    {
        _boxCollider = gameObject.GetComponent<BoxCollider>();
        _size = _boxCollider.size;
        _center = _boxCollider.center;
        _isTrigger = _boxCollider.isTrigger;
        _physMaterial = _boxCollider.material;
    }
}
