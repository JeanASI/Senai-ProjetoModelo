namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline06;uid=wwonline06;password=aluno22senai;";
            return conn;
        }
    }
}