using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKController : MonoBehaviour
{
    [SerializeField] private Transform _leftHandPoint;
    [SerializeField] private Transform _rightHandPoint;
    [SerializeField] private Transform _headPoint;
    [SerializeField, Range(0f, 1f)] private float _leftHandWeight;
    [SerializeField, Range(0f, 1f)] private float _rightHandWeight;
    [SerializeField, Range(0f, 1f)] private float _lookHeadWeight;

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnAnimatorIK(int layerIndex)
    {
        if(_leftHandPoint)
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, _leftHandWeight);
            _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, _leftHandWeight);

            _animator.SetIKPosition(AvatarIKGoal.LeftHand, _leftHandPoint.position);
            _animator.SetIKRotation(AvatarIKGoal.LeftHand, _leftHandPoint.rotation);
        }
        if(_rightHandPoint)
        {
            _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, _rightHandWeight);
            _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, _rightHandWeight);

            _animator.SetIKPosition(AvatarIKGoal.RightHand, _rightHandPoint.position);
            _animator.SetIKRotation(AvatarIKGoal.RightHand, _rightHandPoint.rotation);
        }
    }
}
