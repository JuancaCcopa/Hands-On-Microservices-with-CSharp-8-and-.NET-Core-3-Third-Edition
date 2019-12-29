﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using ProductServiceClient.Models;

namespace ProductServiceClient.Models
{
    public partial class Product
    {
        private Category _category;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public Category Category
        {
            get { return this._category; }
            set { this._category = value; }
        }
        
        private string _categoryId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string CategoryId
        {
            get { return this._categoryId; }
            set { this._categoryId = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _image;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private double? _price;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken categoryValue = inputObject["Category"];
                if (categoryValue != null && categoryValue.Type != JTokenType.Null)
                {
                    Category category = new Category();
                    category.DeserializeJson(categoryValue);
                    this.Category = category;
                }
                JToken categoryIdValue = inputObject["CategoryId"];
                if (categoryIdValue != null && categoryIdValue.Type != JTokenType.Null)
                {
                    this.CategoryId = ((string)categoryIdValue);
                }
                JToken descriptionValue = inputObject["Description"];
                if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                {
                    this.Description = ((string)descriptionValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((string)idValue);
                }
                JToken imageValue = inputObject["Image"];
                if (imageValue != null && imageValue.Type != JTokenType.Null)
                {
                    this.Image = ((string)imageValue);
                }
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
                JToken priceValue = inputObject["Price"];
                if (priceValue != null && priceValue.Type != JTokenType.Null)
                {
                    this.Price = ((double)priceValue);
                }
            }
        }
    }
}