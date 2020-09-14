﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NikoMealBox.Models;
using NikoMealBox.Models.DataTable;
using NikoMealBox.ViewModels;

namespace NikoMealBox.DataAccess.Repository
{
    public class ProductRepository : GenericRepository<Products>
    {

        /// <summary>
        /// 取得所有產品
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductViewModels.Index> Select()
        {
            var products = GetAll().Where(x=>!x.IsDelete && x.IsEnable).Select(x => new ProductViewModels.Index
            {
                Id = x.Id,
                Name = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                Description = x.Description,
                ImagePath = x.ImagePath
            }).AsEnumerable();

            return products;
        }

        /// <summary>
        /// 產品介紹&營養標示
        /// </summary>
        /// <param name="id">產品id</param>
        /// <returns></returns>
        public ProductViewModels.Detail ProductDetail(int? id)
        {
            var prodDeatil = Get(p => p.Id == id);//取回資料庫資料(看繼承就會了解 (DBSet))
            ProductViewModels.Detail prodDetailVM = new ProductViewModels.Detail
            {
                Id = prodDeatil.Id,
                Name = prodDeatil.ProductName,
                UnitPrice = prodDeatil.UnitPrice,
                Description = prodDeatil.Description,
                Materials = prodDeatil.Materials,//商品材料
                Calories = prodDeatil.Calories,//熱量
                Carbohydrate = prodDeatil.Carbohydrate,//碳水化合物
                Protein = prodDeatil.Protein,//蛋白質
                Fat = prodDeatil.Fat,//脂肪
                SaturatedFat = prodDeatil.SaturatedFat,//飽和脂肪
                TransFat = prodDeatil.TransFat,//反式脂肪
                Sugar = prodDeatil.Sugar,//糖
                Sodium = prodDeatil.Sodium,//納
                ImagePath = prodDeatil.ImagePath,//圖片路徑
                IsOvolacto = prodDeatil.IsOvolacto,//蛋奶素
            };
            return prodDetailVM;
        }



        /// <summary>
        /// 搜尋商品
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public IEnumerable<Products> Search(string keyWord)
        {
            return GetAll().Where(x => x.ProductName.Contains(keyWord));
        }

        /// <summary>
        /// 管理頁查詢商品
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Products> SelectAllProducts()
        {
            var product = GetAll();
            return product;
        }
    }
}