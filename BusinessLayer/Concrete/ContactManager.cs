using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactDal _contantdal;

		public ContactManager(IContactDal contantdal)
		{
			_contantdal = contantdal;
		}

		public void ContactAdd(Contact contact)
		{
			_contantdal.Insert(contact);
		}

		public void ContactDelete(Contact contact)
		{
			_contantdal.Delete(contact);
		}

		public void ContactUpdate(Contact contact)
		{
			_contantdal.Update(contact);
		}

		public Contact GetByID(int id)
		{
			return _contantdal.Get(x => x.ContactID == id);	
		}

		public List<Contact> GetList()
		{
			return _contantdal.List();
		}
	}
}
