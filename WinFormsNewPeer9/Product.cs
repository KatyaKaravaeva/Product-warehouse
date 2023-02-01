using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsNewPeer9
{
      public class Product
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string YNK { get; set; }
        public  int Amount { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double Price3 { get; set; }
        public double Price4 { get; set; }
        public string Currency { get; set; }
        public string Guarantee { get; set; }
        public string SpecialOffer { get; set; }
        public string Status { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Link { get; set; }
        public Product()
        {
            
        }
        public Product(string title, string code, string company, string country, string ynk,
            int amount, double price1, double price2, double price3, double minAmount, string currency, 
            string guarantee, string specialOffer, string status, string unitOfMeasure, string link)
        {
            Title = title;
            Code = code;
            Company = company;
            Country = country;
            YNK = ynk;
            Amount = amount;
            Price1 = price1;
            Price2 = price2;
            Price3 = price3;
            Price4 = minAmount;
            Currency = currency;
            Guarantee = guarantee;
            SpecialOffer = specialOffer;
            Status = status;
            UnitOfMeasure = unitOfMeasure;
            Link = link;
        }
        public override string ToString()
        {
            return $"Название - {Title}, Код - {Code},Компания - {Company}\n Страна - {Country}, УНК - {YNK}\n" +
                $"Tекущее количество - {Amount}, Необходимое количество - {Price4}\n" +
                $"Цена1 - {Price1},Цена2 -{Price2},Цена3 - {Price3}\n" +
                $"Валюта - {Currency}, Гарантия - {Guarantee}\n" +
                $"Спец. предложение - {SpecialOffer}, Статус - {Status}\n " +
                $"Единицы измерения - {UnitOfMeasure}, Ссылка - {Link}\n";
        }
    }
}
