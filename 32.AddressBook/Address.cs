using System;
using System.Collections.Generic;
using System.Text;

namespace _32.AddressBook
{
    class Address
    {
        public string name;
        public string address;
        public int gsm;

        public Address(string name, string address, int gsm)
        {
            this.name = name;
            this.address = address;
            this.gsm = gsm;
        }
    }
}
