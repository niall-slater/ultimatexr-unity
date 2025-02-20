﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UxrMetaTouchQuest3Tracking.cs" company="VRMADA">
//   Copyright (c) VRMADA, All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using UltimateXR.Core;

namespace UltimateXR.Devices.Integrations.Meta
{
    /// <summary>
    ///     Tracking for Oculus Touch devices using the Oculus SDK.
    /// </summary>
    public class UxrMetaTouchQuest3Tracking : UxrUnityXRControllerTracking
    {
        #region Public Overrides UxrControllerTracking

        /// <inheritdoc />
        public override Type RelatedControllerInputType => typeof(UxrMetaTouchQuest3Input);

        #endregion

        #region Public Overrides UxrTrackingDevice

        /// <inheritdoc />
        public override string SDKDependency => UxrManager.SdkOculus;

        #endregion
    }
}