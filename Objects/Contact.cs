using System.Collections.Generic;
using System;
using System.Linq;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private int _phoneNumber;
    private string _address;
    private static List<Contact> _instances = new List<Contact> {};
    private int _id;

    public Job(string name, int phoneNumber, string address)
    {
      _name = Name;
      _phoneNumber = phoneNumber;
      _address = address;
      _endDate = endDate;
      _instances.Add(this);
      _id = _instances.Count;
    }
    
    // Getters for Contact Object
    public string GetName()
    {
      return _name;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public string GetAddress()
    {
      return _address;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }

    // Setters for Contact object
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public void SetId(int newId)
    {
      _id = newId;
    }

    // Searches for specific Contact object and returns it
    public static Contact Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}
