﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeOneWeb.Data.Entities
{
    /// <summary>
    /// Items are inanimate objects with can be used in-game for various purposes.
    /// </summary>
    [Table("Item")]
    public class Item
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The display name for this Item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the Item's effect and/or purpose.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// In which <see cref="Entities.BagCategory"/> the Item is sorted in-game.
        /// </summary>
        [ForeignKey("BagCategoryId")]
        public BagCategory BagCategory { get; set; }

        /// <summary>
        /// Foreign key for the BagCategory.
        /// </summary>
        public int BagCategoryId { get; set; }

        /// <summary>
        /// Through which <see cref="PlacedItem"/>s this item can be obtained.
        /// </summary>
        public ICollection<PlacedItem> PlacedItems { get; set; }

        /// <summary>
        /// Through which <see cref="FruitTree"/>s this item can be obtained.
        /// </summary>
        public ICollection<FruitTree> FruitTrees { get; set; }

        /// <summary>
        /// Through which <see cref="ItemGift"/>s this item can be obtained.
        /// </summary>
        public ICollection<ItemGift> ItemGifts { get; set; }

        /// <summary>
        /// By which <see cref="Pokemon"/> this Item is dropped.
        /// </summary>
        public ICollection<PokemonDropItem> DroppedByPokemon { get; set; }

        /// <summary>
        /// By which <see cref="Trainer"/>s this Item is dropped.
        /// </summary>
        public ICollection<TrainerDropItem> DroppedByTrainers { get; set; }

        /// <summary>
        /// By which <see cref="PokemonSpeciesVariety"/> this Item is dropped.
        /// </summary>
        public ICollection<PokemonSpeciesVarietyDropItem> DroppedByPokemonSpeciesVarieties { get; set; }

        /// <summary>
        /// By which <see cref="Quest"/>s this Item is rewarded.
        /// </summary>
        public ICollection<QuestItemReward> QuestRewards { get; set; }

        /// <summary>
        /// Through which <see cref="GloballyObtainableItem"/>s this item can be obtained.
        /// </summary>
        public ICollection<GloballyObtainableItem> GloballyObtainableItems { get; set; }
    }
}
