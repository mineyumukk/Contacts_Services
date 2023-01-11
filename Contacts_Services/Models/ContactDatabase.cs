using Contact;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Contacts_Services.Models
{
    public static class ContactDatabase
    {
        private static List<Rehber> _list;
        private static Contacts contact = new Contacts();

        static ContactDatabase()
        {
            _list = new List<Rehber>();
            _list.Add(new Rehber
            {
                isim = "Emine",
                tel = "05486257426",
                kod = 1234
            });
            _list.Add(new Rehber
            {
                isim = "Ekin",
                tel = "054862534526",
                kod = 1345
            });
            _list.Add(new Rehber
            {
                isim = "Yusuf",
                tel = "02136257426",
                kod = 5678
            });
            _list.Add(new Rehber
            {
                isim = "Ahmet",
                tel = "021324257426",
                kod = 1321
            });

            contact.rehber = _list;

        }
        public static void Add(Rehber model)
        {
            if (_list.Contains(model))
            {
                //Emine
            }
            else
            {
                _list.Add(model);
                contact.rehber = _list;
            }

        }
        public static Contacts getContacts
        {
            get { return contact; }
        }
        public static Rehber editUser([FromBody] Rehber model)
        {
            if (_list.Contains(model))
            {
                //try-catch
                return model;
            }
            else
            {
                var editedModel = _list.FirstOrDefault(x => x.kod == model.kod);
                editedModel.isim = model.isim;
                editedModel.tel = model.tel;
                editedModel.kod = model.kod;
                return model;
            }

        }
        public static void deleteUser(Rehber model)
        {
            var deletedUser = _list.FirstOrDefault(x => x.kod == model.kod && x.isim == model.isim && x.tel == model.tel);
            deletedUser.kod = model.kod;
            _list.Remove(deletedUser);

        }
    }
}