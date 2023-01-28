using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asztali_alkalmazas.Classes
{
    internal class Users
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int Permission { get; private set; }
        public int Deleted { get; private set; }


        public Users()
        {

        }

        public Users(int id, string username, string password, string firstname, string lastname, string email, DateTime birthdate, int permission, int deleted)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.BirthDate = birthdate;
            this.Permission = permission;
            this.Deleted = deleted;
        }
        public void setId(int id)
        {
            Id = _setID(id);
        }
        private int _setID(int i)
        {
            Id = i;
            return Id;
        }
        public void setUsername(string fname, string lname, int i)
        {
            Username = _genUsername(fname, lname, i);
        }

        private string _genUsername(string fname, string lname, int i)
        {
            string username = "";
            username = fname.Substring(0, 3) + lname.Substring(0, 3) + i;

            return username;
        }
        public void setPassword(string password)
        {
            Password = _setPassword(password);
        }
        private string _setPassword(string pwd)
        {
            string password;
            if (pwd.Any(char.IsUpper) && pwd.Any(char.IsDigit) && pwd.Length >= 8)
            {

                password = pwd;
            }
            else
            {
                password = "Default1234";
            }
            return password;
        }
        public void setFirstname(string firstname)
        {
            Firstname = _setFirstname(firstname);
        }

        private string _setFirstname(string firstname)
        {
            string _firstname;
            if (char.IsUpper(firstname.First()))
            {
                _firstname = firstname;
            }
            else
            {
                _firstname = null;
            }

            return _firstname;
        }

        public void setLastname(string lastname)
        {
            Lastname = _setLastname(lastname);
        }
        private string _setLastname(string lastname)
        {
            string _lastname;
            if (char.IsUpper(lastname.First()))
            {
                _lastname = lastname;
            }
            else
            {
                _lastname = null;
            }

            return _lastname;
        }
        public void setEmail(string email)
        {
            Email = _setEmail(email);
        }

        private string _setEmail(string email)
        {
            string mail;
            if (email.Contains("@"))
            {
                mail = email;
            }
            else
            {
                mail = null;
            }
            return mail;
        }
        public void setBirthDate(DateTime birthDate)
        {
            BirthDate = _setBirtDate(birthDate);
        }

        private DateTime _setBirtDate(DateTime birthDate)
        {
            DateTime _birthdate = birthDate;

            return _birthdate;
        }
        public void setPermission(int permission)
        {
            Permission = _setPermission(permission);
        }
        private int _setPermission(int permission)
        {
            int _permission = 0;
            switch (permission)
            {
                case 1:
                    _permission = permission;
                    break;
                case 2:
                    _permission = permission;
                    break;
                case 3:
                    _permission = permission;
                    break;
                default:
                    break;
            }

            return _permission;
        }
        public void setDeleted(bool deleted)
        {
            Deleted = _setDeleted(deleted);
        }

        private int _setDeleted(bool deleted)
        {
            int _deleted;
            if (deleted == true)
            {
                _deleted = 1;
            }
            else
            {
                _deleted = 0;
            }

            return _deleted;
        }
    }
}
