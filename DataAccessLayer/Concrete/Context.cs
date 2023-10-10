using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		public DbSet<About> Abouts { get; set; } //DbSet<About> buradaki About sınıf ismi ; Abouts ise; SQL'deki tablonun ismidir. Diğer alanlarda da aynı durum vardır.
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Content> Contents { get; set; }
		public DbSet<Heading> Headings { get; set; }
		public DbSet<Writer> Writers { get; set; }



	}
}
