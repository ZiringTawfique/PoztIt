using System;
using Domain.SharedModel;

namespace PostItWebApi.Model
{
    public class PostRequest
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string Location { get; set; } // TODO: Revisit datatype
        public string FreeText { get; set; }
        public User User { get; set; }
        //public string Images { get; set; }
        //public string IsCompany { get; set; }
    }
}
