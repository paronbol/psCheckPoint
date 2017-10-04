﻿using System.Management.Automation;

namespace psCheckPoint.Objects.AccessLayer
{
    /// <api cmd="show-access-layer">Get-CheckPointAccessLayer</api>
    /// <summary>
    /// <para type="synopsis">Retrieve existing object using object name or uid.</para>
    /// <para type="description"></para>
    /// </summary>
    /// <example>
    /// <code>Get-CheckPointAccessLayer -Name Network</code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CheckPointAccessLayer")]
    [OutputType(typeof(CheckPointAccessLayer))]
    public class GetCheckPointAccessLayer : GetCheckPointObject<CheckPointAccessLayer>
    {
        /// <summary>
        /// <para type="description">Check Point Web-API command that should be called.</para>
        /// </summary>
        public override string Command { get { return "show-access-layer"; } }
    }
}