﻿using System.Management.Automation;

namespace psCheckPoint.Objects.Group
{
    /// <api cmd="delete-group">Remove-CheckPointGroup</api>
    /// <summary>
    /// <para type="synopsis">Delete existing object using object name or uid.</para>
    /// <para type="description"></para>
    /// </summary>
    /// <example>
    ///   <code>Remove-CheckPointGroup -Name Test1 -Verbose</code>
    /// </example>
    [Cmdlet(VerbsCommon.Remove, "CheckPointGroup")]
    public class RemoveCheckPointGroup : RemoveCheckPointObject
    {
        /// <summary>
        /// <para type="description">Check Point Web-API command that should be called.</para>
        /// </summary>
        public override string Command { get { return "delete-group"; } }
    }
}