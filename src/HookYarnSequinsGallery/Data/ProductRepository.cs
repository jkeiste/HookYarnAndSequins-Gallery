﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HookYarnSequinsGallery.Models;

namespace HookYarnSequinsGallery.Data
{
    public class ProductRepository
    {
        private static Product[] _products = new Product[]
        {
            new Product()
            {
                Id = 1,
                SeriesTitle = "Beatrice The Bunny",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" }
                },
                Favorite = false
            },
            new Product()
            {
                Id = 2,
                SeriesTitle = "Bertie The Bunny",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorite = false
            },
            new Product()
            {
                Id = 3,
                SeriesTitle = "Walter The Whale",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            },
            new Product()
            {
                Id = 4,
                SeriesTitle = "Jamie Jules Jellyfish",
                DescriptionHtml = "<p>Cute little jellyfish.</p>"
            }
        };

        public Product[] GetProducts()
        {
            return _products;
        }

        public Product GetProduct(int id)
        {
            Product productToReturn = null;

            foreach (var product in _products)
            {
                if (product.Id == id)
                {
                    productToReturn = product;

                    break;
                }
            }

            return productToReturn;
        }
    }
}