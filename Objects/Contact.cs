using System.Collections.Generic;
using System;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private static List<Contact> _instances = new List<Contact> {};
    private int _id;

    public Contact(string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
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
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }

    // Setters for Contact object
    public void SetName(string newName)
    {
      _name = newName;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public void SetId(int newId)
    {
      _id = newId;
    }

    // Deletes all contacts
    public static void DeleteAllContacts()
    {
      _instances.Clear();
    }

    // Searches for specific Contact object and returns it
    public static Contact Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}
