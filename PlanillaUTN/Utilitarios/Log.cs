using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Utilitarios
{
    class Log
    {
        public static void LogSQLException(SqlException pExcepcion)
        {
            string texto = CreateSQLExceptionsErrorDetails(pExcepcion);

            // TODO: guardar usando log4net
        }

        public static void LogGenericException(Exception pExcepcion)
        {
            string texto = CreateGenericErrorExceptionDetail(pExcepcion);

            // TODO: guardar usando log4net
        }
        public static string CreateSQLExceptionsErrorDetails(SqlException pExcepcion)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("\n");
            msg.AppendFormat("Lista de Errores \n");
            for (int i = 0; i < pExcepcion.Errors.Count; i++)
            {
                msg.AppendFormat("\t{0} de {1}\n", i + 1, pExcepcion.Errors.Count);
                msg.AppendFormat("\tNumber    : {1}\n", i + 1, pExcepcion.Errors[i].Number);
                msg.AppendFormat("\tLineNumber: {1}\n", i + 1, pExcepcion.Errors[i].LineNumber);
                msg.AppendFormat("\tMessage   : {1}\n", i + 1, pExcepcion.Errors[i].Message);

            }
            msg.AppendFormat("\n");
            msg.AppendFormat("StackTrace     {0}\n", pExcepcion.StackTrace);
            msg.AppendFormat(@"Info de errores para investigar mas https://technet.microsoft.com/en-us/library/cc645603(v=sql.105).aspx");
            return msg.ToString();
        }

        public static string CreateSQLExceptionsErrorDetails(MethodBase pMethodBase, IDbCommand pCommand, SqlException pExcepcion)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("\nClase: {0}\n", pMethodBase.DeclaringType);
            msg.AppendFormat("Method: {0}\n", pMethodBase.Name);
            msg.AppendFormat("\n");
            msg.AppendFormat("Lista de Errores \n");
            for (int i = 0; i < pExcepcion.Errors.Count; i++)
            {
                msg.AppendFormat("\t{0} de {1}\n", i + 1, pExcepcion.Errors.Count);
                msg.AppendFormat("\tNumber    : {1}\n", i + 1, pExcepcion.Errors[i].Number);
                msg.AppendFormat("\tLineNumber: {1}\n", i + 1, pExcepcion.Errors[i].LineNumber);
                msg.AppendFormat("\tMessage   : {1}\n", i + 1, pExcepcion.Errors[i].Message);
            }
            msg.AppendFormat("\n");
            msg.AppendFormat("StackTrace     {0}\n", pExcepcion.StackTrace);
            msg.AppendFormat("SQL donde ocurrió el error: {0}\n", pCommand != null ? pCommand.CommandText : "N/A");
            msg.AppendFormat("Info de errores para investigar mas {0}\n", @"https://technet.microsoft.com/en-us/library/cc645603(v=sql.105).aspx");
            msg.AppendFormat("{0}\n", "".PadRight(100, '-'));
            return msg.ToString();
        }

        public static string CreateGenericErrorExceptionDetail(Exception pExcepcion)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("Message    :{0}\n", pExcepcion.Message);
            msg.AppendFormat("Source     :{0}\n", pExcepcion.Source);
            msg.AppendFormat("StackTrace :{0}\n", pExcepcion.StackTrace);

            if (pExcepcion.InnerException != null)
            {
                msg.AppendFormat("InnerException Message    :{0}\n", pExcepcion.InnerException.Message);
                msg.AppendFormat("InnerException Source     :{0}\n", pExcepcion.InnerException.Source);
                msg.AppendFormat("InnerException StackTrace :{0}\n", pExcepcion.InnerException.StackTrace);
            }
            msg.AppendFormat("{0}\n", "".PadRight(100, '-'));
            return msg.ToString();
        }

        public static string CreateGenericErrorExceptionDetail(MethodBase pMethodBase, Exception pExcepcion)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendFormat("\nClase    :{0}\n", pMethodBase.DeclaringType);
            msg.AppendFormat("Method     :{0}\n", pMethodBase.Name);
            msg.AppendFormat("Message    :{0}\n", pExcepcion.Message);
            msg.AppendFormat("Source     :{0}\n", pExcepcion.Source);
            msg.AppendFormat("StackTrace :{0}\n", pExcepcion.StackTrace);
            msg.AppendFormat("{0}\n", "".PadRight(100, '-'));
            return msg.ToString();
        }
    }
}
