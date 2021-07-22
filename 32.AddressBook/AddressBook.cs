using System;
using System.Collections.Generic;
using System.Text;

namespace _32.AddressBook
{
    class AddressBook
    {
        //list for the addressess
        List<Address> addresses;
        public AddressBook()
        {
            addresses = new List<Address>();
        }
        //add new address for person in the list
        public bool add(string name, string address, int gsm)
        {
            Address add = new Address(name, address, gsm);
            Address result = find(name);

            if (result == null)
            {
                addresses.Add(add);
                return true;
            }
            else
            {
                return false;
            }
        }
        //remove address from list
        public bool remove(string name)
        {
            Address add = find(name);
            if (add != null)
            {
                addresses.Remove(add);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void list(Action<Address> action)
        {
            addresses.ForEach(action);
        }
        public bool isEmpty()
        {
            return (addresses.Count == 0);
        }
        public Address find(string name)
        {
            Address add = addresses.Find((a) => a.name == name);
            return add;
        }
    }
}
