// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Type.Model.Inheritance.NestedDiscriminator.Models
{
    /// <summary> The second level model in polymorphic multiple levels inheritance which contains references to other polymorphic instances. </summary>
    public partial class Salmon : Fish
    {
        /// <summary> Initializes a new instance of <see cref="Salmon"/>. </summary>
        /// <param name="age"></param>
        public Salmon(int age) : base(age)
        {
            Kind = "salmon";
            Friends = new ChangeTrackingList<Fish>();
            Hate = new ChangeTrackingDictionary<string, Fish>();
        }

        /// <summary> Initializes a new instance of <see cref="Salmon"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="age"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="friends">
        /// Please note <see cref="Fish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GoblinShark"/>, <see cref="Salmon"/>, <see cref="SawShark"/> and <see cref="Shark"/>.
        /// </param>
        /// <param name="hate">
        /// Please note <see cref="Fish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GoblinShark"/>, <see cref="Salmon"/>, <see cref="SawShark"/> and <see cref="Shark"/>.
        /// </param>
        /// <param name="partner">
        /// Please note <see cref="Fish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GoblinShark"/>, <see cref="Salmon"/>, <see cref="SawShark"/> and <see cref="Shark"/>.
        /// </param>
        internal Salmon(string kind, int age, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<Fish> friends, IDictionary<string, Fish> hate, Fish partner) : base(kind, age, serializedAdditionalRawData)
        {
            Friends = friends;
            Hate = hate;
            Partner = partner;
        }

        /// <summary> Initializes a new instance of <see cref="Salmon"/> for deserialization. </summary>
        internal Salmon()
        {
        }

        /// <summary>
        /// Gets the friends
        /// Please note <see cref="Fish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GoblinShark"/>, <see cref="Salmon"/>, <see cref="SawShark"/> and <see cref="Shark"/>.
        /// </summary>
        public IList<Fish> Friends { get; }
        /// <summary>
        /// Gets the hate
        /// Please note <see cref="Fish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GoblinShark"/>, <see cref="Salmon"/>, <see cref="SawShark"/> and <see cref="Shark"/>.
        /// </summary>
        public IDictionary<string, Fish> Hate { get; }
        /// <summary>
        /// Gets or sets the partner
        /// Please note <see cref="Fish"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GoblinShark"/>, <see cref="Salmon"/>, <see cref="SawShark"/> and <see cref="Shark"/>.
        /// </summary>
        public Fish Partner { get; set; }
    }
}
