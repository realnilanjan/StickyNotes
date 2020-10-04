using Dapper;
using StickyNotes.Lib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Lib.DataAccess
{
    public class SqliteDataAccess
    {
        private string GetConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }
        }

        public List<NoteModel> LoadNotes()
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString))
            {
                var output = connection.Query<NoteModel>(Queries.GetNotesQuery, new DynamicParameters());
                return output.ToList();
            }
        }

        public void SaveNote(NoteModel note)
        {
            using (IDbConnection connection = new SQLiteConnection(GetConnectionString))
            {
                connection.Execute(Queries.InsertNotesQuery, note);
            }
        }
    }
}
