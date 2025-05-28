﻿using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor))]
public class ActivateRotatingInteractor : MonoBehaviour
{
    public DialInteractable DialToActivate;

    UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor m_Interactor;
    void Start()
    {
        m_Interactor = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRBaseInteractor>();
        m_Interactor.selectEntered.AddListener(Activated);
    }

    void Activated(SelectEnterEventArgs args)
    {
        var interactable = args.interactable;
        
        DialToActivate.RotatingRigidbody = interactable.GetComponentInChildren<Rigidbody>();
        DialToActivate.gameObject.SetActive(true);

        interactable.interactionLayerMask = 0;
    }
}
