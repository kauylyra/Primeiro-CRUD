using System;

namespace BancoRafa.Models
{
    internal class MaxLenghtAttribute : Attribute
    {
        public MaxLenghtAttribute(int v, string ErrorMessage)
        {
            V = v;
            this.ErrorMessage = ErrorMessage;
        }

        public string ErrorMessage { get; set; }
        public int V { get; }
    }
}