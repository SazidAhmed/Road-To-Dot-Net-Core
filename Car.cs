using System;

namespace Item
{
  class Category
  {
    private string name;

    //property
    public string N{
      set{ name = value; }
      get{ return name; }
    }

    public float P{ get; set; }
  }
}