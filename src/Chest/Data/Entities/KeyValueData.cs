﻿// Copyright (c) Lykke Corp.
// See the LICENSE file in the project root for more information.

namespace Chest.Data
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Represents a key value pair to be stored in data store
    /// </summary>
    [Table("key_value_data")]
    internal class KeyValueData
    {
        /// <summary>
        /// Gets or sets category
        /// </summary>
        [MaxLength(100)]
        [Column("category", Order = 0)]
        [DefaultValue("metadata")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets collection
        /// </summary>
        [MaxLength(100)]
        [Column("collection", Order = 1)]
        [DefaultValue("metadata")]
        public string Collection { get; set; }

        /// <summary>
        /// Gets or sets Key
        /// </summary>
        [MaxLength(100)]
        [Column("key", Order = 2)]
        public string Key { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("display_category")]
        [DefaultValue("metadata")]
        public string DisplayCategory { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("display_collection")]
        [DefaultValue("metadata")]
        public string DisplayCollection { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("display_key")]
        public string DisplayKey { get; set; }

        /// <summary>
        /// Gets or sets the json data associated with the given key
        /// </summary>
        [Required]
        [MaxLength(4096)]
        [Column("meta_data")]
        public string MetaData { get; set; }

        public override string ToString() => $"{this.Key}:{this.MetaData}";
    }
}
