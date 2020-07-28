// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AppConfiguration.Models
{
    /// <summary> The Tag. </summary>
    public partial class Tag
    {
        /// <summary> Initializes a new instance of Tag. </summary>
        public Tag()
        {
        }

        /// <summary> Initializes a new instance of Tag. </summary>
        /// <param name="id"> . </param>
        /// <param name="name"> . </param>
        internal Tag(long? id, string name)
        {
            Id = id;
            Name = name;
        }

        public long? Id { get; set; }
        public string Name { get; set; }
    }
}