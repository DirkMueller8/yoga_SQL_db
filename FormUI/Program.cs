using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
/********************************************************
Author: Dirk Mueller
Date: 2020-10-25

Implementation adapted from Tim Corey, see
 https://www.youtube.com/watch?v=Et2khGnrIqc&t=293s/
1. ADO.NET to connect via C# code (in Visual Studio 2019) 
   to a SQL database
2. Dapper as an object mapper for ADO.NET data reader 
   (https://dapper-tutorial.net/dapper)
3. WinForm GUI
4. Utilization of stored procedures in SQL Server Management 
   Studio to ensure a safe connection
5. Reading from a database (SELECT * FROM) by a search term 
   for a particular column in T-SQL
6. Writing to (INSERT) the database in T-SQL
 *********************************************************/
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard());
        }
    }
}
