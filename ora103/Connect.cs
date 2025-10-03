using MySql.Data.MySqlClient;

namespace ora103
{
    public class Connect
    {
        public MySqlConnection Connection;
        private string _host;
        private string _db;
        private string _user;
        private string _password;

        private string connectionstring;

        public Connect()
        {
            _host = "localhost";
            _db = "library";
            _user = "root";
            _password = "";

            connectionstring = $"SERVER={_host}; DATABASE={_db}; UID = {_user}; PASSWORD={_password};SslMode=none";

            Connection = new MySqlConnection(connectionstring);


        }
    }
}
