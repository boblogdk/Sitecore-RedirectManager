// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemToItem.cs">
//   Copyright (C) 2012 by Alexander Davyduk. All rights reserved.
// </copyright>
// <summary>
//   ItemToItem class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Sitecore.SharedSource.RedirectManager.Templates
{

    /// <summary>
    /// ItemToItem class
    /// </summary>
    public sealed class ItemToItem : CustomItem
    {
        // Fields

        /// <summary>
        ///  ItemToItemTemplate template ID
        /// </summary>
        public const string TemplateId = "{D0BFFA7B-CA51-400D-9037-809DECFB14D3}";

        /// <summary>
        ///  Base Item field
        /// </summary>
        private TextField _baseItem;

        /// <summary>
        /// Target Item field
        /// </summary>
        private LinkField _targetItem;

        /// <summary>
        /// The redirect code
        /// </summary>
        private int _redirectCode;

        /// <summary>
        /// The date of last use
        /// </summary>
        private DateField _lastUse;

        // Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemToItem"/> class.
        /// </summary>
        /// <param name="innerItem">
        /// The inner item.
        /// </param>
        public ItemToItem(Item innerItem)
            : base(innerItem)
        {
        }

        // Properties

        /// <summary>
        /// Gets the base item.
        /// </summary>
        public TextField BaseItem
        {
            get
            {
                return _baseItem ?? (_baseItem = InnerItem.Fields["Base Item"]);
            }
        }

        /// <summary>
        /// Gets the target item.
        /// </summary>
        public LinkField TargetItem
        {
            get
            {
                return _targetItem ?? (_targetItem = InnerItem.Fields["Target Item"]);
            }
        }

        /// <summary>
        /// Gets the redirect code.
        /// </summary>
        /// <value>
        /// The redirect code.
        /// </value>
        public int RedirectCode
        {
            get
            {
                return _redirectCode == 0 
                    ? (_redirectCode = MainUtil.GetInt(InnerItem.Fields["Redirect Code"], Configuration.RedirectStatusCode)) 
                    : _redirectCode;
            }
        }

        /// <summary>
        /// Gets the last use.
        /// </summary>
        /// <value>
        /// The last use.
        /// </value>
        public DateField LastUse
        {
            get
            {
                return _lastUse ?? (_lastUse = InnerItem.Fields["Last Use"]);
            }
        }
    }
}