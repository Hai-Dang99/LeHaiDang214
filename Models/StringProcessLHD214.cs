using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeHaiDang214.Models
{
    public class StringProcessLHD214
    {
        public string LowerToUpper(string strInput)
        {
            return strInput.ToUpper();
        }
    }
}