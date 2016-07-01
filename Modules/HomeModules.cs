using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
      return View["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["view_contacts.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View["add_contact.cshtml"];
      };
      Post["/contact_created"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone-number"], Request.Form["new-address"]);
        return View["contact_details.cshtml", newContact];
      };
      Get["/contact/details/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["/contact_details.cshtml", contact];
      };
      Get["/contact/details/edit/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["/edit_contact.cshtml", contact];
      };
      Post["/contact/details/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        contact.SetName(Request.Form["new-name"]);
        contact.SetPhoneNumber(Request.Form["new-phone-number"]);
        contact.SetAddress(Request.Form["new-address"]);
        return View["/contact_details.cshtml", contact];
      };
    }
  }
}
