using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookMyShow.ViewModels.Response
{
    public class ResponseViewModel
    {
       

        public string Message { get; set; }

        public List<string> Error { get; set; }

     
    }
}
