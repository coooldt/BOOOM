using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
namespace Assets.BasicModule.Model
{
  [Serializable]
  public class Dish
  {
    public enum DishType
    {
      None = 0,
      Normal = 1,
      Special = 2
    }
    [Category("ID"), Description("唯一ID")]
    public int ID { get; set; }
    [Category("Description"), Description("菜品名")]
    public string Name { get; set; }
    [Category("Description"), Description("菜品描述")]
    public string Description { get; set; }

    [Category("Value"), Description("菜品健康值")]
    public double DishHealth { get; set; }
    [Category("Value"), Description("菜品San值")]
    public double DishSanity { get; set; }
    [Category("Value"), Description("菜品饱食度")]
    public double DishSatiety { get; set; }
    //料理成功度系数
    [Category("Value"), Description("菜品成功度系数")]
    public double Successfulness { get; set; } = 1.0;
    [Category("Type"), Description("菜品类型")]
    public DishType Type { get; set; }
    [Category("Type"), Description("菜品特殊属性")]
    public List<FoodProperty> Properties { get; set; } = new List<FoodProperty>();


  }
}