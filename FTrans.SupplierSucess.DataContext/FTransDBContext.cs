using FTrans.SupplierSuccess.DataContext.DataEntities;
using FTrans.SupplierSuccess.DataContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FTrans.SupplierSuccess.DataContext
{
    public class FTransDBContext: DbContext,IDisposable
    {
        string _connectionString;

        public FTransDBContext(string connectionString):base(connectionString)
        {
            _connectionString = connectionString;
        }

        public DbRawSqlQuery<T> ExecuteStoteProcedure<T>(string procedureName, params DbParameter[] Params)
        {

            StringBuilder query = new StringBuilder();
            query.Append(" exec  ");
            query.Append(procedureName);
            query.Append(" ");
            var querystring = string.Empty;
            if (Params != null)
            {
                foreach (var param in Params)
                {
                    query.Append(param.ParameterName);
                    query.Append(" ,");
                }
                querystring = query.ToString().Substring(0, query.ToString().Length - 1);
            }
            this.Database.CommandTimeout = 0;
            return this.Database.SqlQuery<T>(querystring, Params);
        }

        public DbRawSqlQuery<T> ExecuteStoteProcedure<T>(string procedureName, string connectionString, params DbParameter[] Params)
        {
            using (FTransDBContext storeProcedureDataContext = new FTransDBContext(connectionString))
            {
                StringBuilder query = new StringBuilder();
                query.Append(" exec  ");
                query.Append(procedureName);
                query.Append(" ");
                var querystring = string.Empty;
                if (Params != null)
                {
                    foreach (var param in Params)
                    {
                        query.Append(param.ParameterName);
                        query.Append(" ,");
                    }
                    querystring = query.ToString().Substring(0, query.ToString().Length - 1);
                }

                return storeProcedureDataContext.Database.SqlQuery<T>(querystring, Params);
            }
        }

        public DbRawSqlQuery<T> ExecuteQuery<T>(string Query, params DbParameter[] Params)
        {
            return this.Database.SqlQuery<T>(Query, Params);
        }

        public DbParameter GetNewParameter(string Name, object Value, DbType Type = DbType.String,
            ParameterDirection Direction = ParameterDirection.Input)
        {
            return new SqlParameter()
            {
                ParameterName = "@" + Name.Replace("@", ""),
                Value = Value == null ? DBNull.Value : Value,
                DbType = Type,
                Direction = Direction
            };
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<FTransDBContext>(null);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
