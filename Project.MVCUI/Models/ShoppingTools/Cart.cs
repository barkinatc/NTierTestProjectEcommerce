﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Models.ShoppingTools
{
    public class Cart
    {
        Dictionary<int, CartItem> _sepetim;

        public Cart()
        {
            _sepetim = new Dictionary<int, CartItem>(); 
        }

        public List<CartItem> Sepetim
        {
            get
            {
                return _sepetim.Values.ToList();
            }
        }

        public void SepeteEkle(CartItem item)
        {
            if (_sepetim.ContainsKey(item.ID))
            {
                _sepetim[item.ID].Amount++;
                return;
            }
            _sepetim.Add(item.ID, item);
        }
    }
}