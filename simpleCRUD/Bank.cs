using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace simpleCRUD
{
    class Bank
    {
        //propiedades
        public int _bankId { get; set; }
        public string _nombre { get; set; }
        public string _direccion { get; set; }
        public string _clientnumber { get; set; }
        public string _phonenumber { get; set; }

        //instancia a la clase Crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla Book
        public MySqlDataReader getAllBank()
        {
            string query = "SELECT bankId,nombre,direccion,clientnumber,phonenumber FROM bank";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditBook(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO bank(bankId, nombre, direccion, clientnumber, phonenumber)" +
                    "VALUES ('" + _bankId + "', '" + _nombre + "', '" + _direccion + "', '" + _clientnumber + "', '" + _phonenumber + "')";
                crud.executeQuery(query); //llamado al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE book SET "
                    + "title='" + _nombre + "' ,"
                    + "subtitle='" + _direccion + "',"
                    + "isbn='" + _clientnumber + "',"
                    + "publishedDate='" + _phonenumber + "'"
                    + "WHERE "
                    + "bookId='" + _bankId + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }

        //metodo para eliminar
        public Boolean deleteBank()
        {
            string query = "DELETE FROM book WHERE bookId='" + _bankId + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}
