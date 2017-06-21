// -----------------------------------------------------------------------------
// <copyright file="MachineOptionList.cs" company="Sequoia Voting Systems"> 
//     Copyright (c) 2008 Sequoia Voting Systems, Inc. All Rights Reserved.
//     Distribution of source code is allowable only under the terms of the
//     license agreement found at http://www.sequoiavote.com/license.html
// </copyright>
// <summary>
//     This file contains the MachineParamList class.
// </summary>
// <revision revisor="dev16" date="12/22/2008" version="1.0.0.0">
//     File Created
// </revision>  
// <revision revisor="dev16" date="1/27/2009" version="1.0.5.7">
//     File Modified
// </revision>
// -----------------------------------------------------------------------------

namespace Sequoia.DomainObjects
{
    #region Using directives

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using Persistence;

    #endregion

    /// <summary>
    ///     List of Machine Options
    /// </summary>
    /// <externalUnit/>
    /// <revision revisor="dev16" date="12/22/2008" version="1.0.0.0">
    ///     Class created.
    /// </revision>
    /// <revision revisor="dev16" date="1/26/2009" version="1.0.5.7">
    /// Added implementation of IPersistable
    /// </revision>
    [Serializable]
    [XmlRoot("MachineOptions")]
    public class MachineOptionList : DomainObjectList<MachineOption>, 
        IPersistible
    {
        #region Fields

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="MachineOptionList"/> class.
        /// </summary>
        /// <externalUnit/>
        /// <revision revisor="dev16" date="12/22/2008" version="1.0.0.0">
        ///     Member Created
        /// </revision> 
        public MachineOptionList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MachineOptionList"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <externalUnit cref="List{T}(int)"/>
        /// <revision revisor="dev16" date="12/22/2008" version="1.0.0.0">
        /// Member created.
        /// </revision>
        public MachineOptionList(int capacity) : base(capacity)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MachineOptionList"/> class.
        /// </summary>
        /// <param name="machineParams">The machine params.</param>
        /// <externalUnit cref="List{T}(IEnumerable{T})"/>
        /// <externalUnit cref="IEnumerable{T}"/>
        /// <revision revisor="dev16" date="12/22/2008" version="1.0.0.0">
        /// Member created.
        /// </revision>
        public MachineOptionList(IEnumerable<MachineOption> machineParams) : 
            base(machineParams)
        {
        }

        #endregion

        #region Public Properties
        /// <summary>
        ///     Gets the serialized data.
        /// </summary>
        /// <value>The serialized data.</value>
        /// <externalUnit/>
        /// <revision revisor="dev16" date="1/26/2009" version="1.0.5.7">
        ///     Member created.
        /// </revision>
        public string SerializedData
        {
            get
            {
                return Serialize(this);
            }
        }

        #endregion

        #region Public Methods

        #endregion

        #region Public Events

        #endregion

        #region Private Methods

        #endregion

        #region IPersistable Members

        /// <summary>
        ///     Sets the persister.
        /// </summary>
        /// <param name="persister">The persister.</param>
        /// <externalUnit/>
        /// <revision revisor="dev16" date="1/26/2009" version="1.0.5.7">
        ///     Member created.
        /// </revision>
        public void SetPersister(IPersister persister)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
